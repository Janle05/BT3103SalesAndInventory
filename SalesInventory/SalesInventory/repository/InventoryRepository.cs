using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;

namespace SalesInventory.Repository
{
    public class InventoryRepository
    {
        private readonly DatabaseConnection db;

        public InventoryRepository()
        {
            db = new DatabaseConnection();
        }
        public List<InventoryItem> GetInventory(string keyword)
        {
            List<InventoryItem> list = new List<InventoryItem>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        p.ProductID,
                        p.ProductName,
                        c.CategoryName,
                        p.StockQuantity,
                        p.ReorderLevel,
                        CASE WHEN p.StockQuantity <= 0 THEN 'Out of Stock'
                             WHEN p.StockQuantity <= p.ReorderLevel THEN 'Low Stock'
                             ELSE 'In Stock' END AS StockStatus
                    FROM Products p
                    INNER JOIN Categories c ON c.CategoryID = p.CategoryID
                    WHERE p.Status = 'Active'
                      AND (p.ProductName LIKE @Keyword OR c.CategoryName LIKE @Keyword)
                    ORDER BY p.ProductName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new InventoryItem
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                ProductName = reader["ProductName"]?.ToString() ?? "",
                                CategoryName = reader["CategoryName"]?.ToString() ?? "",
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                                ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]),
                                StockStatus = reader["StockStatus"]?.ToString() ?? ""
                            });
                        }
                    }
                }
            }

            return list;
        }

        // Dagdag (positive) o bawas (negative) sa stock + history
        public void ChangeStock(int productID, int change, string movementType, string reason, int userID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        int rows;

                        string updateQuery = @"
                            UPDATE Products
                            SET StockQuantity = StockQuantity + @Change
                            WHERE ProductID = @ProductID
                              AND StockQuantity + @Change >= 0";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@Change", change);
                            cmd.Parameters.AddWithValue("@ProductID", productID);
                            rows = cmd.ExecuteNonQuery();
                        }

                        if (rows == 0)
                        {
                            throw new Exception("Not enough stock, or the product was not found.");
                        }

                        InsertMovement(con, tran, productID, movementType, change, reason, userID);

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // Itakda ang eksaktong bilang ng stock (physical count)
        public void SetStock(int productID, int newQuantity, string reason, int userID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        int currentStock;

                        string selectQuery = @"
                            SELECT StockQuantity
                            FROM Products WITH (UPDLOCK)
                            WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(selectQuery, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productID);

                            object? result = cmd.ExecuteScalar();

                            if (result == null || result == DBNull.Value)
                            {
                                throw new Exception("Product not found.");
                            }

                            currentStock = Convert.ToInt32(result);
                        }

                        int change = newQuantity - currentStock;

                        string updateQuery = @"
                            UPDATE Products
                            SET StockQuantity = @NewQuantity
                            WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                            cmd.Parameters.AddWithValue("@ProductID", productID);
                            cmd.ExecuteNonQuery();
                        }

                        InsertMovement(con, tran, productID, "Count Adjustment", change, reason, userID);

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        private static void InsertMovement(
            SqlConnection con,
            SqlTransaction tran,
            int productID,
            string movementType,
            int quantity,
            string reason,
            int userID)
        {
            string query = @"
                INSERT INTO StockMovements
                    (ProductID, MovementType, Quantity, Reason, UserID)
                VALUES
                    (@ProductID, @MovementType, @Quantity, @Reason, @UserID)";

            using (SqlCommand cmd = new SqlCommand(query, con, tran))
            {
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@MovementType", movementType);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Reason", reason);
                cmd.Parameters.AddWithValue("@UserID", userID > 0 ? (object)userID : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
