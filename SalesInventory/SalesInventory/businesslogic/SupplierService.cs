using SalesInventory.Repository;
using System;
using System.Collections.Generic;

namespace SalesInventory.businesslogic
{
    public class SupplierService
    {
        private readonly SupplierRepository repository;

        public SupplierService()
        {
            repository = new SupplierRepository();
        }

      

        public void AddSupplier(Supplier supplier)
        {
            ValidateSupplier(supplier);

            if (repository.SupplierExists(supplier.SupplierName))
            {
                throw new Exception(
                    "A supplier with the same name already exists.");
            }

            repository.AddSupplier(supplier);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return repository.GetAllSuppliers();
        }

       

        public void UpdateSupplier(Supplier supplier)
        {
            ValidateSupplier(supplier);

            if (repository.SupplierExists(
                supplier.SupplierName,
                supplier.SupplierID))
            {
                throw new Exception(
                    "A supplier with the same name already exists.");
            }

            repository.UpdateSupplier(supplier);
        }

       

        public void DeactivateSupplier(int supplierID)
        {
            if (supplierID <= 0)
            {
                throw new Exception("Invalid supplier ID.");
            }

            repository.DeactivateSupplier(supplierID);
        }


        public List<Supplier> SearchSuppliers(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return repository.GetAllSuppliers();
            }

            return repository.SearchSuppliers(keyword.Trim());
        }

        private void ValidateSupplier(Supplier supplier)
        {
            if (supplier == null)
            {
                throw new Exception("Supplier information is required.");
            }

            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            {
                throw new Exception("Supplier name is required.");
            }

            if (string.IsNullOrWhiteSpace(supplier.ContactPerson))
            {
                throw new Exception("Contact person is required.");
            }

            if (string.IsNullOrWhiteSpace(supplier.PhoneNumber))
            {
                throw new Exception("Phone number is required.");
            }

            foreach (char c in supplier.PhoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    throw new Exception(
                        "Phone number must contain numbers only.");
                }
            }
        }
    }
}