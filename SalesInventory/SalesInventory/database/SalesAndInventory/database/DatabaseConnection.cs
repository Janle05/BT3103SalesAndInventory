using Microsoft.Data.SqlClient;

namespace SalesInventory.Database
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            @"Server=(localdb)\ProjectModels;Database=database;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}