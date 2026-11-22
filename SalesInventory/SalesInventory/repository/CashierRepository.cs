using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;
using System;
using System.Collections.Generic;

namespace SalesInventory.Repository
{
    public class CashierRepository
    {
        private readonly DatabaseConnection db;

        public CashierRepository()
        {
            db = new DatabaseConnection();
        }

        // Mga product na pwedeng ibenta (Active at may stock)
        // categoryID = 0 ay ibig sabihin lahat ng category
        public List<ProductForSale> GetProductsForSale(string keyword, int categoryID)
        {
            List<ProductForSale> list = new List<ProductForSale>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        p.ProductID,
                        p.ProductName,
                        c.CategoryName,
                        p.UnitPrice,
                        p.StockQuantity
                    FROM Products p
                    INNER JOIN Categories c ON c.CategoryID = p.CategoryID
                    WHERE p.Status = 'Active'
                      AND p.StockQuantity > 0
                      AND (@CategoryID = 0 OR p.CategoryID = @CategoryID)
                      AND p.ProductName LIKE @Keyword
                    ORDER BY p.ProductName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ProductForSale
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                ProductName = reader["ProductName"]?.ToString() ?? "",
                                CategoryName = reader["CategoryName"]?.ToString() ?? "",
                                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        // CHECKOUT: lahat ay nasa isang transaction.
        // Kapag may isang pumalya (halimbawa kulang ang stock), walang masasave kahit isa.
        public int CreateSale(int cashierID, List<OrderLine> lines, string paymentMethod, decimal amountPaid)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        // 1) Gumawa ng Sale (ia-update ang total sa dulo)
                        int saleID;

                        string insertSale = @"
                            INSERT INTO Sales (SaleDate, CashierID, TotalAmount)
                            VALUES (GETDATE(), @CashierID, 0);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        using (SqlCommand cmd = new SqlCommand(insertSale, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@CashierID", cashierID);
                            saleID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        decimal total = 0;

                        // 2) Para sa bawat item: bawasan ang stock, kunin ang presyo mula sa database,
                        //    itala ang SaleItem at StockMovement
                        foreach (OrderLine line in lines)
                        {
                            decimal unitPrice;

                            string updateStock = @"
                                UPDATE Products
                                SET StockQuantity = StockQuantity - @Qty
                                OUTPUT inserted.UnitPrice
                                WHERE ProductID = @ProductID
                                  AND Status = 'Active'
                                  AND StockQuantity >= @Qty";

                            using (SqlCommand cmd = new SqlCommand(updateStock, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@Qty", line.Quantity);
                                cmd.Parameters.AddWithValue("@ProductID", line.ProductID);

                                object? result = cmd.ExecuteScalar();

                                if (result == null || result == DBNull.Value)
                                {
                                    throw new Exception(
                                        "Not enough stock for \"" + line.ProductName + "\". " +
                                        "Please refresh the product list and try again.");
                                }

                                unitPrice = Convert.ToDecimal(result);
                            }

                            decimal lineTotal = unitPrice * line.Quantity;
                            total += lineTotal;

                            string insertItem = @"
                                INSERT INTO SaleItems (SaleID, ProductID, Quantity, UnitPrice, LineTotal)
                                VALUES (@SaleID, @ProductID, @Qty, @UnitPrice, @LineTotal)";

                            using (SqlCommand cmd = new SqlCommand(insertItem, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@SaleID", saleID);
                                cmd.Parameters.AddWithValue("@ProductID", line.ProductID);
                                cmd.Parameters.AddWithValue("@Qty", line.Quantity);
                                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                cmd.Parameters.AddWithValue("@LineTotal", lineTotal);
                                cmd.ExecuteNonQuery();
                            }

                            string insertMovement = @"
                                INSERT INTO StockMovements (ProductID, MovementType, Quantity, Reason, UserID)
                                VALUES (@ProductID, 'Sale', @Qty, @Reason, @UserID)";

                            using (SqlCommand cmd = new SqlCommand(insertMovement, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@ProductID", line.ProductID);
                                cmd.Parameters.AddWithValue("@Qty", -line.Quantity);
                                cmd.Parameters.AddWithValue("@Reason", "Sale #" + saleID);
                                cmd.Parameters.AddWithValue("@UserID", cashierID > 0 ? (object)cashierID : DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 3) Payment. Ang non-cash (halimbawa GCash) ay eksaktong halaga lang.
                        bool isCash = paymentMethod.Equals("Cash", StringComparison.OrdinalIgnoreCase);

                        if (!isCash)
                        {
                            amountPaid = total;
                        }

                        if (amountPaid < total)
                        {
                            throw new Exception("The amount received is less than the total.");
                        }

                        decimal change = amountPaid - total;

                        using (SqlCommand cmd = new SqlCommand(
                            "UPDATE Sales SET TotalAmount = @Total WHERE SaleID = @SaleID", con, tran))
                        {
                            cmd.Parameters.AddWithValue("@Total", total);
                            cmd.Parameters.AddWithValue("@SaleID", saleID);
                            cmd.ExecuteNonQuery();
                        }

                        string insertPayment = @"
                            INSERT INTO Payments (SaleID, PaymentDate, PaymentMethod, AmountPaid, ChangeAmount)
                            VALUES (@SaleID, GETDATE(), @Method, @Paid, @Change)";

                        using (SqlCommand cmd = new SqlCommand(insertPayment, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@SaleID", saleID);
                            cmd.Parameters.AddWithValue("@Method", paymentMethod);
                            cmd.Parameters.AddWithValue("@Paid", amountPaid);
                            cmd.Parameters.AddWithValue("@Change", change);
                            cmd.ExecuteNonQuery();
                        }

                        tran.Commit();

                        return saleID;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // Datos para sa resibo
        public ReceiptData GetReceipt(int saleID)
        {
            ReceiptData receipt = new ReceiptData();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string headerQuery = @"
                    SELECT
                        s.SaleID,
                        s.SaleDate,
                        u.Username,
                        s.TotalAmount,
                        ISNULL(p.PaymentMethod, '') AS PaymentMethod,
                        ISNULL(p.AmountPaid, s.TotalAmount) AS AmountPaid,
                        ISNULL(p.ChangeAmount, 0) AS ChangeAmount
                    FROM Sales s
                    INNER JOIN Users u ON u.UserID = s.CashierID
                    LEFT JOIN Payments p ON p.SaleID = s.SaleID
                    WHERE s.SaleID = @SaleID";

                using (SqlCommand cmd = new SqlCommand(headerQuery, con))
                {
                    cmd.Parameters.AddWithValue("@SaleID", saleID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new Exception("Sale #" + saleID + " was not found.");
                        }

                        receipt.SaleID = Convert.ToInt32(reader["SaleID"]);
                        receipt.SaleDate = Convert.ToDateTime(reader["SaleDate"]);
                        receipt.Cashier = reader["Username"]?.ToString() ?? "";
                        receipt.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                        receipt.PaymentMethod = reader["PaymentMethod"]?.ToString() ?? "";
                        receipt.AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                        receipt.ChangeAmount = Convert.ToDecimal(reader["ChangeAmount"]);
                    }
                }

                string itemsQuery = @"
                    SELECT
                        p.ProductName,
                        si.Quantity,
                        si.UnitPrice,
                        si.LineTotal
                    FROM SaleItems si
                    INNER JOIN Products p ON p.ProductID = si.ProductID
                    WHERE si.SaleID = @SaleID
                    ORDER BY si.SaleItemID";

                using (SqlCommand cmd = new SqlCommand(itemsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@SaleID", saleID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receipt.Items.Add(new ReceiptItem
                            {
                                ProductName = reader["ProductName"]?.ToString() ?? "",
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                                LineTotal = Convert.ToDecimal(reader["LineTotal"])
                            });
                        }
                    }
                }
            }

            return receipt;
        }

        // Mga benta ng isang cashier sa pagitan ng dalawang petsa
        public List<CashierSaleRecord> GetSalesByCashier(int cashierID, DateTime from, DateTime to)
        {
            List<CashierSaleRecord> list = new List<CashierSaleRecord>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        s.SaleID,
                        s.SaleDate,
                        ISNULL((SELECT SUM(si.Quantity)
                                FROM SaleItems si
                                WHERE si.SaleID = s.SaleID), 0) AS Items,
                        s.TotalAmount,
                        ISNULL(p.PaymentMethod, '') AS PaymentMethod
                    FROM Sales s
                    LEFT JOIN Payments p ON p.SaleID = s.SaleID
                    WHERE s.CashierID = @CashierID
                      AND s.SaleDate >= @From
                      AND s.SaleDate < @To
                    ORDER BY s.SaleDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CashierID", cashierID);
                    cmd.Parameters.AddWithValue("@From", from.Date);
                    cmd.Parameters.AddWithValue("@To", to.Date.AddDays(1));

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new CashierSaleRecord
                            {
                                SaleID = Convert.ToInt32(reader["SaleID"]),
                                SaleDate = Convert.ToDateTime(reader["SaleDate"]),
                                Items = Convert.ToInt32(reader["Items"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                PaymentMethod = reader["PaymentMethod"]?.ToString() ?? ""
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
