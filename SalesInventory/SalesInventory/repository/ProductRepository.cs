using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;

namespace SalesInventory.Repository
{
    public class ProductRepository
    {
        private readonly DatabaseConnection db;

        public ProductRepository()
        {
            db = new DatabaseConnection();
        }

        // CREATE
        public void AddProduct(Product product)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    INSERT INTO Products
                    (
                        ProductName,
                        CategoryID,
                        SupplierID,
                        UnitPrice,
                        StockQuantity,
                        InitialStock,
                        ReorderLevel,
                        Status
                    )
                    VALUES
                    (
                        @ProductName,
                        @CategoryID,
                        @SupplierID,
                        @UnitPrice,
                        @StockQuantity,
                        @InitialStock,
                        @ReorderLevel,
                        @Status
                    )";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    cmd.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    cmd.Parameters.AddWithValue("@InitialStock", product.InitialStock);
                    cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                    cmd.Parameters.AddWithValue("@Status", product.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // READ
        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        ProductID,
                        ProductName,
                        CategoryID,
                        SupplierID,
                        UnitPrice,
                        StockQuantity,
                        InitialStock,
                        ReorderLevel,
                        Status
                    FROM Products
                    ORDER BY ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(ReadProduct(reader));
                        }
                    }
                }
            }

            return list;
        }

        // UPDATE
        // Hindi na ginagalaw dito ang stock. Sa Inventory form na babaguhin ang stock
        // para may history (StockMovements) at hindi nabubura ang stock kapag nag-update ng presyo.
        public void UpdateProduct(Product product)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Products
                    SET
                        ProductName = @ProductName,
                        CategoryID = @CategoryID,
                        SupplierID = @SupplierID,
                        UnitPrice = @UnitPrice,
                        ReorderLevel = @ReorderLevel,
                        Status = @Status
                    WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    cmd.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                    cmd.Parameters.AddWithValue("@Status", product.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DEACTIVATE
        public void DeactivateProduct(int productID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Products
                    SET Status = 'Inactive'
                    WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // SEARCH
        public List<Product> SearchProducts(string keyword)
        {
            List<Product> list = new List<Product>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        ProductID,
                        ProductName,
                        CategoryID,
                        SupplierID,
                        UnitPrice,
                        StockQuantity,
                        InitialStock,
                        ReorderLevel,
                        Status
                    FROM Products
                    WHERE ProductName LIKE @Keyword
                    ORDER BY ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(ReadProduct(reader));
                        }
                    }
                }
            }

            return list;
        }

        // DASHBOARD: mga numero sa apat na kulay na box
        public DashboardStats GetDashboardStats()
        {
            DashboardStats stats = new DashboardStats();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        COUNT(*) AS TotalProducts,
                        ISNULL(SUM(StockQuantity), 0) AS TotalStocks,
                        ISNULL(SUM(CASE WHEN StockQuantity > 0
                                         AND StockQuantity <= ReorderLevel THEN 1 ELSE 0 END), 0) AS LowStocks,
                        ISNULL(SUM(CASE WHEN StockQuantity <= 0 THEN 1 ELSE 0 END), 0) AS OutOfStocks
                    FROM Products
                    WHERE Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            stats.TotalProducts = Convert.ToInt32(reader["TotalProducts"]);
                            stats.TotalStocks = Convert.ToInt32(reader["TotalStocks"]);
                            stats.LowStocks = Convert.ToInt32(reader["LowStocks"]);
                            stats.OutOfStocks = Convert.ToInt32(reader["OutOfStocks"]);
                        }
                    }
                }
            }

            return stats;
        }

        // DASHBOARD: listahan ng low stock / out of stock
        public List<LowStockItem> GetLowStockItems()
        {
            List<LowStockItem> list = new List<LowStockItem>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        ProductID,
                        ProductName,
                        StockQuantity,
                        ReorderLevel,
                        CASE WHEN StockQuantity <= 0 THEN 'Out of Stock'
                             ELSE 'Low Stock' END AS StockStatus
                    FROM Products
                    WHERE Status = 'Active'
                      AND StockQuantity <= ReorderLevel
                    ORDER BY StockQuantity, ProductName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new LowStockItem
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                ProductName = reader["ProductName"]?.ToString() ?? "",
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

        private static Product ReadProduct(SqlDataReader reader)
        {
            return new Product
            {
                ProductID = Convert.ToInt32(reader["ProductID"]),
                ProductName = reader["ProductName"]?.ToString() ?? "",
                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                InitialStock = Convert.ToInt32(reader["InitialStock"]),
                ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]),
                Status = reader["Status"]?.ToString() ?? "Active"
            };
        }
    }
}
