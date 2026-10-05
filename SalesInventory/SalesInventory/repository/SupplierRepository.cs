using Microsoft.Data.SqlClient;
using SalesInventory.BusinessLogic;
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
                    (SupplierName, ContactPerson, Phone, Email, Address, Status)
                    VALUES
                    (@SupplierName, @ContactPerson, @Phone, @Email, @Address, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@ContactPerson", (object)supplier.ContactPerson ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", (object)supplier.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)supplier.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)supplier.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", string.IsNullOrEmpty(supplier.Status) ? "Active" : supplier.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> list = new List<Supplier>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT SupplierID, SupplierName, ContactPerson, Phone, Email, Address, Status
                    FROM Suppliers
                    ORDER BY SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Supplier
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                SupplierName = reader["SupplierName"].ToString(),
                                ContactPerson = reader["ContactPerson"] == DBNull.Value ? "" : reader["ContactPerson"].ToString(),
                                Phone = reader["Phone"] == DBNull.Value ? "" : reader["Phone"].ToString(),
                                Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString(),
                                Address = reader["Address"] == DBNull.Value ? "" : reader["Address"].ToString(),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Suppliers
                    SET SupplierName = @SupplierName,
                        ContactPerson = @ContactPerson,
                        Phone = @Phone,
                        Email = @Email,
                        Address = @Address,
                        Status = @Status
                    WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@ContactPerson", (object)supplier.ContactPerson ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", (object)supplier.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)supplier.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)supplier.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", supplier.Status);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSupplier(int supplierID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    UPDATE Suppliers
                    SET Status = 'Inactive'
                    WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Supplier> SearchSuppliers(string keyword)
        {
            List<Supplier> list = new List<Supplier>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                    SELECT SupplierID, SupplierName, ContactPerson, Phone, Email, Address, Status
                    FROM Suppliers
                    WHERE SupplierName LIKE @Keyword
                       OR ContactPerson LIKE @Keyword
                       OR Phone LIKE @Keyword";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Supplier
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                SupplierName = reader["SupplierName"].ToString(),
                                ContactPerson = reader["ContactPerson"] == DBNull.Value ? "" : reader["ContactPerson"].ToString(),
                                Phone = reader["Phone"] == DBNull.Value ? "" : reader["Phone"].ToString(),
                                Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString(),
                                Address = reader["Address"] == DBNull.Value ? "" : reader["Address"].ToString(),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
