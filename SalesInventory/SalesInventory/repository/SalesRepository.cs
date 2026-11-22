using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;

namespace SalesInventory.Repository
{
    public class SalesRepository
    {
        private readonly DatabaseConnection db;

        public SalesRepository()
        {
            db = new DatabaseConnection();
        }

        public List<SaleRecord> GetSales(DateTime from, DateTime to)
        {
            List<SaleRecord> list = new List<SaleRecord>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        s.SaleID,
                        s.SaleDate,
                        u.Username AS Cashier,
                        ISNULL((SELECT SUM(si.Quantity)
                                FROM SaleItems si
                                WHERE si.SaleID = s.SaleID), 0) AS Items,
                        s.TotalAmount
                    FROM Sales s
                    INNER JOIN Users u ON u.UserID = s.CashierID
                    WHERE s.SaleDate >= @From
                      AND s.SaleDate < @To
                    ORDER BY s.SaleDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@From", from.Date);
                    cmd.Parameters.AddWithValue("@To", to.Date.AddDays(1));

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new SaleRecord
                            {
                                SaleID = Convert.ToInt32(reader["SaleID"]),
                                SaleDate = Convert.ToDateTime(reader["SaleDate"]),
                                Cashier = reader["Cashier"]?.ToString() ?? "",
                                Items = Convert.ToInt32(reader["Items"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<PaymentRecord> GetPayments(DateTime from, DateTime to)
        {
            List<PaymentRecord> list = new List<PaymentRecord>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        PaymentID,
                        SaleID,
                        PaymentDate,
                        PaymentMethod,
                        AmountPaid,
                        ChangeAmount
                    FROM Payments
                    WHERE PaymentDate >= @From
                      AND PaymentDate < @To
                    ORDER BY PaymentDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@From", from.Date);
                    cmd.Parameters.AddWithValue("@To", to.Date.AddDays(1));

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PaymentRecord
                            {
                                PaymentID = Convert.ToInt32(reader["PaymentID"]),
                                SaleID = Convert.ToInt32(reader["SaleID"]),
                                PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                                PaymentMethod = reader["PaymentMethod"]?.ToString() ?? "",
                                AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                                ChangeAmount = Convert.ToDecimal(reader["ChangeAmount"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<ProductSalesRow> GetProductSales(DateTime from, DateTime to)
        {
            List<ProductSalesRow> list = new List<ProductSalesRow>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        p.ProductName,
                        SUM(si.Quantity) AS QuantitySold,
                        SUM(si.LineTotal) AS Revenue
                    FROM SaleItems si
                    INNER JOIN Sales s ON s.SaleID = si.SaleID
                    INNER JOIN Products p ON p.ProductID = si.ProductID
                    WHERE s.SaleDate >= @From
                      AND s.SaleDate < @To
                    GROUP BY p.ProductName
                    ORDER BY SUM(si.LineTotal) DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@From", from.Date);
                    cmd.Parameters.AddWithValue("@To", to.Date.AddDays(1));

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ProductSalesRow
                            {
                                ProductName = reader["ProductName"]?.ToString() ?? "",
                                QuantitySold = Convert.ToInt32(reader["QuantitySold"]),
                                Revenue = Convert.ToDecimal(reader["Revenue"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        public SalesSummary GetSummary(DateTime from, DateTime to)
        {
            SalesSummary summary = new SalesSummary();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        ISNULL(SUM(TotalAmount), 0) AS TotalSales,
                        COUNT(*) AS TotalTransactions
                    FROM Sales
                    WHERE SaleDate >= @From
                      AND SaleDate < @To";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@From", from.Date);
                    cmd.Parameters.AddWithValue("@To", to.Date.AddDays(1));

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            summary.TotalSales = Convert.ToDecimal(reader["TotalSales"]);
                            summary.TotalTransactions = Convert.ToInt32(reader["TotalTransactions"]);
                        }
                    }
                }
            }

            return summary;
        }
    }
}
