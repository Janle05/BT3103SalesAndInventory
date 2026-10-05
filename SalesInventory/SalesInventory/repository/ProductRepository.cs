using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.BusinessLogic;
using SalesInventory.Database;
using System;
using System.Collections.Generic;

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
                        @InitialStock,
                        @ReorderLevel,
                        @Status
                    )";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@ProductName",
                        product.ProductName);

                    cmd.Parameters.AddWithValue(
                        "@CategoryID",
                        product.CategoryID);

                    cmd.Parameters.AddWithValue(
                        "@SupplierID",
                        product.SupplierID);

                    cmd.Parameters.AddWithValue(
                        "@UnitPrice",
                        product.UnitPrice);

                    cmd.Parameters.AddWithValue(
                        "@InitialStock",
                        product.InitialStock);

                    cmd.Parameters.AddWithValue(
                        "@ReorderLevel",
                        product.ReorderLevel);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        product.Status);

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
                        InitialStock,
                        ReorderLevel,
                        Status
                    FROM Products
                    ORDER BY ProductID";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Product
                            {
                                ProductID =
                                    Convert.ToInt32(
                                        reader["ProductID"]),

                                ProductName =
                                    reader["ProductName"]?.ToString() ?? "",

                                CategoryID =
                                    Convert.ToInt32(
                                        reader["CategoryID"]),

                                SupplierID =
                                    Convert.ToInt32(
                                        reader["SupplierID"]),

                                UnitPrice =
                                    Convert.ToDecimal(
                                        reader["UnitPrice"]),

                                InitialStock =
                                    Convert.ToInt32(
                                        reader["InitialStock"]),

                                ReorderLevel =
                                    Convert.ToInt32(
                                        reader["ReorderLevel"]),

                                Status =
                                    reader["Status"]?.ToString()
                                    ?? "Active"
                            });
                        }
                    }
                }
            }

            return list;
        }

        // UPDATE
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
                        InitialStock = @InitialStock,
                        ReorderLevel = @ReorderLevel,
                        Status = @Status
                    WHERE ProductID = @ProductID";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@ProductID",
                        product.ProductID);

                    cmd.Parameters.AddWithValue(
                        "@ProductName",
                        product.ProductName);

                    cmd.Parameters.AddWithValue(
                        "@CategoryID",
                        product.CategoryID);

                    cmd.Parameters.AddWithValue(
                        "@SupplierID",
                        product.SupplierID);

                    cmd.Parameters.AddWithValue(
                        "@UnitPrice",
                        product.UnitPrice);

                    cmd.Parameters.AddWithValue(
                        "@InitialStock",
                        product.InitialStock);

                    cmd.Parameters.AddWithValue(
                        "@ReorderLevel",
                        product.ReorderLevel);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        product.Status);

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

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@ProductID",
                        productID);

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
                        InitialStock,
                        ReorderLevel,
                        Status
                    FROM Products
                    WHERE ProductName LIKE @Keyword
                    ORDER BY ProductID";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@Keyword",
                        "%" + keyword + "%");

                    con.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Product
                            {
                                ProductID =
                                    Convert.ToInt32(
                                        reader["ProductID"]),

                                ProductName =
                                    reader["ProductName"]?.ToString() ?? "",

                                CategoryID =
                                    Convert.ToInt32(
                                        reader["CategoryID"]),

                                SupplierID =
                                    Convert.ToInt32(
                                        reader["SupplierID"]),

                                UnitPrice =
                                    Convert.ToDecimal(
                                        reader["UnitPrice"]),

                                InitialStock =
                                    Convert.ToInt32(
                                        reader["InitialStock"]),

                                ReorderLevel =
                                    Convert.ToInt32(
                                        reader["ReorderLevel"]),

                                Status =
                                    reader["Status"]?.ToString()
                                    ?? "Active"
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}