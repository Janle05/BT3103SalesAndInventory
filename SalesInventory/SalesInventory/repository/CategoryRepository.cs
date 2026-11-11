using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;
using System;
using System.Collections.Generic;

namespace SalesInventory.Repository
{
    public class CategoryRepository
    {
        private readonly DatabaseConnection db;

        public CategoryRepository()
        {
            db = new DatabaseConnection();
        }

        public void AddCategory(Category category)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    INSERT INTO Categories
                    (CategoryName, Description, Status)
                    VALUES
                    (@CategoryName, @Description, @Status)";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@CategoryName",
                        category.CategoryName);

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        (object)category.Description ?? DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        category.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> list = new List<Category>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT CategoryID,
                           CategoryName,
                           Description,
                           Status
                    FROM Categories
                    ORDER BY CategoryID";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Category
                            {
                                CategoryID =
                                    Convert.ToInt32(
                                        reader["CategoryID"]),

                                CategoryName =
                                    reader["CategoryName"].ToString(),

                                Description =
                                    reader["Description"] == DBNull.Value
                                    ? ""
                                    : reader["Description"].ToString(),

                                Status =
                                    reader["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public void UpdateCategory(Category category)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Categories
                    SET CategoryName = @CategoryName,
                        Description = @Description,
                        Status = @Status
                    WHERE CategoryID = @CategoryID";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@CategoryID",
                        category.CategoryID);

                    cmd.Parameters.AddWithValue(
                        "@CategoryName",
                        category.CategoryName);

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        (object)category.Description ?? DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        category.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCategory(int categoryID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    DELETE FROM Categories
                    WHERE CategoryID = @CategoryID";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@CategoryID",
                        categoryID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Category> SearchCategories(string keyword)
        {
            List<Category> list = new List<Category>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT CategoryID,
                           CategoryName,
                           Description,
                           Status
                    FROM Categories
                    WHERE CategoryName LIKE @Keyword
                       OR Description LIKE @Keyword";

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
                            list.Add(new Category
                            {
                                CategoryID =
                                    Convert.ToInt32(
                                        reader["CategoryID"]),

                                CategoryName =
                                    reader["CategoryName"].ToString(),

                                Description =
                                    reader["Description"] == DBNull.Value
                                    ? ""
                                    : reader["Description"].ToString(),

                                Status =
                                    reader["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}