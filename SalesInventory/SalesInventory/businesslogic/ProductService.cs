using SalesInventory.BusinessLogic;
using SalesInventory.Repository;

namespace SalesInventory.businesslogic
{
    public class ProductService
    {
        private readonly ProductRepository repository;

        public ProductService()
        {
            repository = new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new Exception("Product name is required.");

            if (product.UnitPrice < 0)
                throw new Exception("Unit price cannot be negative.");

            if (product.InitialStock < 0)
                throw new Exception("Initial stock cannot be negative.");

            if (product.ReorderLevel < 0)
                throw new Exception("Reorder level cannot be negative.");

            repository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public void UpdateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new Exception("Product name is required.");

            if (product.UnitPrice < 0)
                throw new Exception("Unit price cannot be negative.");

            if (product.InitialStock < 0)
                throw new Exception("Initial stock cannot be negative.");

            if (product.ReorderLevel < 0)
                throw new Exception("Reorder level cannot be negative.");

            repository.UpdateProduct(product);
        }

        public void DeactivateProduct(int productID)
        {
            repository.DeactivateProduct(productID);
        }

        public List<Product> SearchProducts(string keyword)
        {
            return repository.SearchProducts(keyword);
        }
    }
}