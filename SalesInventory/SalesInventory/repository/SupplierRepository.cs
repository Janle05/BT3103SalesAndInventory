using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.Database;
using System;
using System.Collections.Generic;

namespace SalesInventory.Repository
{
    public class SupplierRepository
    {
        private readonly DatabaseConnection db;

        public SupplierRepository()
        {
            db = new DatabaseConnection();
        }

        public void AddSupplier(Supplier supplier)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    INSERT INTO Suppliers
                    (
                        SupplierName,
                        ContactPerson,
                        PhoneNumber,
                        EmailAddress,
                        PhysicalAddress,
                        Status
                    )
                    VALUES
                    (
                        @SupplierName,
                        @ContactPerson,
                        @PhoneNumber,
                        @EmailAddress,
                        @PhysicalAddress,
                        @Status
                    )";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@SupplierName", supplier.SupplierName);

                    cmd.Parameters.AddWithValue(
                        "@ContactPerson", supplier.ContactPerson);

                    cmd.Parameters.AddWithValue(
                        "@PhoneNumber", supplier.PhoneNumber);

                    cmd.Parameters.AddWithValue(
                        "@EmailAddress",
                        string.IsNullOrWhiteSpace(supplier.EmailAddress)
                            ? (object)DBNull.Value
                            : supplier.EmailAddress);

                    cmd.Parameters.AddWithValue(
                        "@PhysicalAddress",
                        string.IsNullOrWhiteSpace(supplier.PhysicalAddress)
                            ? (object)DBNull.Value
                            : supplier.PhysicalAddress);

                    cmd.Parameters.AddWithValue(
                        "@Status", supplier.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        SupplierID,
                        SupplierName,
                        ContactPerson,
                        PhoneNumber,
                        EmailAddress,
                        PhysicalAddress,
                        Status
                    FROM Suppliers
                    ORDER BY SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier
                            {
                                SupplierID =
                                    Convert.ToInt32(reader["SupplierID"]),

                                SupplierName =
                                    reader["SupplierName"]?.ToString() ?? "",

                                ContactPerson =
                                    reader["ContactPerson"]?.ToString() ?? "",

                                PhoneNumber =
                                    reader["PhoneNumber"]?.ToString() ?? "",

                                EmailAddress =
                                    reader["EmailAddress"] == DBNull.Value
                                        ? ""
                                        : reader["EmailAddress"]?.ToString() ?? "",

                                PhysicalAddress =
                                    reader["PhysicalAddress"] == DBNull.Value
                                        ? ""
                                        : reader["PhysicalAddress"]?.ToString() ?? "",

                                Status =
                                    reader["Status"]?.ToString() ?? "Active"
                            });
                        }
                    }
                }
            }

            return suppliers;
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Suppliers
                    SET
                        SupplierName = @SupplierName,
                        ContactPerson = @ContactPerson,
                        PhoneNumber = @PhoneNumber,
                        EmailAddress = @EmailAddress,
                        PhysicalAddress = @PhysicalAddress,
                        Status = @Status
                    WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@SupplierID", supplier.SupplierID);

                    cmd.Parameters.AddWithValue(
                        "@SupplierName", supplier.SupplierName);

                    cmd.Parameters.AddWithValue(
                        "@ContactPerson", supplier.ContactPerson);

                    cmd.Parameters.AddWithValue(
                        "@PhoneNumber", supplier.PhoneNumber);

                    cmd.Parameters.AddWithValue(
                        "@EmailAddress",
                        string.IsNullOrWhiteSpace(supplier.EmailAddress)
                            ? (object)DBNull.Value
                            : supplier.EmailAddress);

                    cmd.Parameters.AddWithValue(
                        "@PhysicalAddress",
                        string.IsNullOrWhiteSpace(supplier.PhysicalAddress)
                            ? (object)DBNull.Value
                            : supplier.PhysicalAddress);

                    cmd.Parameters.AddWithValue(
                        "@Status", supplier.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeactivateSupplier(int supplierID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Suppliers
                    SET Status = 'Inactive'
                    WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@SupplierID", supplierID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Supplier> SearchSuppliers(string keyword)
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT
                        SupplierID,
                        SupplierName,
                        ContactPerson,
                        PhoneNumber,
                        EmailAddress,
                        PhysicalAddress,
                        Status
                    FROM Suppliers
                    WHERE SupplierName LIKE @Keyword
                       OR ContactPerson LIKE @Keyword
                       OR PhoneNumber LIKE @Keyword
                       OR EmailAddress LIKE @Keyword
                    ORDER BY SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@Keyword", "%" + keyword + "%");

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier
                            {
                                SupplierID =
                                    Convert.ToInt32(reader["SupplierID"]),

                                SupplierName =
                                    reader["SupplierName"]?.ToString() ?? "",

                                ContactPerson =
                                    reader["ContactPerson"]?.ToString() ?? "",

                                PhoneNumber =
                                    reader["PhoneNumber"]?.ToString() ?? "",

                                EmailAddress =
                                    reader["EmailAddress"] == DBNull.Value
                                        ? ""
                                        : reader["EmailAddress"]?.ToString() ?? "",

                                PhysicalAddress =
                                    reader["PhysicalAddress"] == DBNull.Value
                                        ? ""
                                        : reader["PhysicalAddress"]?.ToString() ?? "",

                                Status =
                                    reader["Status"]?.ToString() ?? "Active"
                            });
                        }
                    }
                }
            }

            return suppliers;
        }

        public bool SupplierExists(
            string supplierName,
            int supplierID = 0)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Suppliers
                    WHERE SupplierName = @SupplierName
                      AND SupplierID <> @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@SupplierName", supplierName);

                    cmd.Parameters.AddWithValue(
                        "@SupplierID", supplierID);

                    con.Open();

                    int count =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}