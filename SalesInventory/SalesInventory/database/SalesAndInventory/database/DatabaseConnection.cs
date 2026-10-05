using Microsoft.Data.SqlClient;

namespace SalesInventory.Database
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            @"Server=JHONLEE-0518\SQLEXPRESS;Database=SalesInventory;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}