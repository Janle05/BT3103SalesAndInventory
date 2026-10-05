using Microsoft.Data.SqlClient;
using SalesInventory.BusinessLogic;
using SalesInventory.Database;
using System;
using System.Collections.Generic;

namespace SalesInventory.Repository
{
    public class SupplierRepository
    {
        private readonly DatabaseConnection databaseConnection;

        public SupplierRepository()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void AddSupplier(Supplier supplier)
        {
            using SqlConnection connection = databaseConnection.GetConnection();

            string query = @"
                INSERT INTO Suppliers
                (
                    SupplierName,
                    ContactPerson,
                    Phone,
                    Email,
                    Address,
                    Status
                )
                VALUES
                (
                    @SupplierName,
                    @ContactPerson,
                    @Phone,
                    @Email,
                    @Address,
                    @Status
                )";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
            command.Parameters.AddWithValue("@ContactPerson",
                string.IsNullOrWhiteSpace(supplier.ContactPerson)
                    ? DBNull.Value
                    : supplier.ContactPerson);
            command.Parameters.AddWithValue("@Phone",
                string.IsNullOrWhiteSpace(supplier.Phone)
                    ? DBNull.Value
                    : supplier.Phone);
            command.Parameters.AddWithValue("@Email",
                string.IsNullOrWhiteSpace(supplier.Email)
                    ? DBNull.Value
                    : supplier.Email);
            command.Parameters.AddWithValue("@Address",
                string.IsNullOrWhiteSpace(supplier.Address)
                    ? DBNull.Value
                    : supplier.Address);
            command.Parameters.AddWithValue("@Status", supplier.Status);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using SqlConnection connection = databaseConnection.GetConnection();

            string query = @"
                SELECT
                    SupplierID,
                    SupplierName,
                    ContactPerson,
                    Phone,
                    Email,
                    Address,
                    Status
                FROM Suppliers
                ORDER BY SupplierID DESC";

            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                suppliers.Add(new Supplier
                {
                    SupplierID = Convert.ToInt32(reader["SupplierID"]),
                    SupplierName = reader["SupplierName"].ToString() ?? "",
                    ContactPerson = reader["ContactPerson"] == DBNull.Value
                        ? ""
                        : reader["ContactPerson"].ToString() ?? "",
                    Phone = reader["Phone"] == DBNull.Value
                        ? ""
                        : reader["Phone"].ToString() ?? "",
                    Email = reader["Email"] == DBNull.Value
                        ? ""
                        : reader["Email"].ToString() ?? "",
                    Address = reader["Address"] == DBNull.Value
                        ? ""
                        : reader["Address"].ToString() ?? "",
                    Status = reader["Status"].ToString() ?? "Active"
                });
            }

            return suppliers;
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using SqlConnection connection = databaseConnection.GetConnection();

            string query = @"
                UPDATE Suppliers
                SET
                    SupplierName = @SupplierName,
                    ContactPerson = @ContactPerson,
                    Phone = @Phone,
                    Email = @Email,
                    Address = @Address,
                    Status = @Status
                WHERE SupplierID = @SupplierID";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
            command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
            command.Parameters.AddWithValue("@ContactPerson",
                string.IsNullOrWhiteSpace(supplier.ContactPerson)
                    ? DBNull.Value
                    : supplier.ContactPerson);
            command.Parameters.AddWithValue("@Phone",
                string.IsNullOrWhiteSpace(supplier.Phone)
                    ? DBNull.Value
                    : supplier.Phone);
            command.Parameters.AddWithValue("@Email",
                string.IsNullOrWhiteSpace(supplier.Email)
                    ? DBNull.Value
                    : supplier.Email);
            command.Parameters.AddWithValue("@Address",
                string.IsNullOrWhiteSpace(supplier.Address)
                    ? DBNull.Value
                    : supplier.Address);
            command.Parameters.AddWithValue("@Status", supplier.Status);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void DeleteSupplier(int supplierID)
        {
            using SqlConnection connection = databaseConnection.GetConnection();

            string query = @"
                UPDATE Suppliers
                SET Status = 'Inactive'
                WHERE SupplierID = @SupplierID";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", supplierID);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public List<Supplier> SearchSuppliers(string keyword)
        {
            List<Supplier> suppliers = new List<Supplier>();

            using SqlConnection connection = databaseConnection.GetConnection();

            string query = @"
                SELECT
                    SupplierID,
                    SupplierName,
                    ContactPerson,
                    Phone,
                    Email,
                    Address,
                    Status
                FROM Suppliers
                WHERE
                    SupplierName LIKE @Keyword
                    OR ContactPerson LIKE @Keyword
                    OR Phone LIKE @Keyword
                ORDER BY SupplierID DESC";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                suppliers.Add(new Supplier
                {
                    SupplierID = Convert.ToInt32(reader["SupplierID"]),
                    SupplierName = reader["SupplierName"].ToString() ?? "",
                    ContactPerson = reader["ContactPerson"] == DBNull.Value
                        ? ""
                        : reader["ContactPerson"].ToString() ?? "",
                    Phone = reader["Phone"] == DBNull.Value
                        ? ""
                        : reader["Phone"].ToString() ?? "",
                    Email = reader["Email"] == DBNull.Value
                        ? ""
                        : reader["Email"].ToString() ?? "",
                    Address = reader["Address"] == DBNull.Value
                        ? ""
                        : reader["Address"].ToString() ?? "",
                    Status = reader["Status"].ToString() ?? "Active"
                });
            }

            return suppliers;
        }
    }
}