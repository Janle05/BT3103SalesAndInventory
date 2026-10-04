using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;
using System;

namespace SalesInventory.Repository
{
    public class UserRepository
    {
        private readonly DatabaseConnection databaseConnection;

        public UserRepository()
        {
            databaseConnection = new DatabaseConnection();
        }

        public User? GetUser(string username, string password)
        {
            User? user = null;

            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                string query = @"
                    SELECT UserID, Username, Password, Role
                    FROM Users
                    WHERE Username = @Username
                    AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString() ?? string.Empty,
                                Password = reader["Password"].ToString() ?? string.Empty,
                                Role = reader["Role"].ToString() ?? string.Empty
                            };
                        }
                    }
                }
            }

            return user;
        }
    }
}