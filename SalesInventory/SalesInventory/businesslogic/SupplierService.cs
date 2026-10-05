using SalesInventory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SalesInventory.BusinessLogic
{
    public class SupplierService
    {
        private readonly SupplierRepository repository;

        public SupplierService()
        {
            repository = new SupplierRepository();
        }

        public void SaveSupplier(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            {
                throw new Exception("Supplier Name is required.");
            }

            if (!string.IsNullOrWhiteSpace(supplier.Phone) &&
                !Regex.IsMatch(supplier.Phone, @"^[0-9+\-\s()]+$"))
            {
                throw new Exception(
                    "Phone number must contain numbers only.");
            }

            List<Supplier> existingSuppliers =
                repository.GetAllSuppliers();

            bool isDuplicate = existingSuppliers.Any(s =>
                s.SupplierName.Equals(
                    supplier.SupplierName,
                    StringComparison.OrdinalIgnoreCase) &&
                s.SupplierID != supplier.SupplierID);

            if (isDuplicate)
            {
                throw new Exception(
                    "A supplier with this name already exists.");
            }

            if (supplier.SupplierID == 0)
            {
                supplier.Status = "Active";
                repository.AddSupplier(supplier);
            }
            else
            {
                repository.UpdateSupplier(supplier);
            }
        }

        public List<Supplier> GetSuppliers()
        {
            return repository.GetAllSuppliers();
        }

        public void DeactivateSupplier(int supplierID)
        {
            repository.DeleteSupplier(supplierID);
        }

        public List<Supplier> SearchSuppliers(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetSuppliers();
            }

            return repository.SearchSuppliers(keyword);
        }
    }
}