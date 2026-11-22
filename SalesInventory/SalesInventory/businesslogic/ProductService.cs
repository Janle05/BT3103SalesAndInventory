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
            ValidateProduct(product);

            // Ang Initial Stock na nilagay ay siyang unang Stock Quantity
            product.StockQuantity = product.InitialStock;

            repository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public void UpdateProduct(Product product)
        {
            if (product.ProductID <= 0)
                throw new Exception("Please select a product first.");

            ValidateProduct(product);

            repository.UpdateProduct(product);
        }

        public void DeactivateProduct(int productID)
        {
            if (productID <= 0)
                throw new Exception("Invalid product ID.");

            repository.DeactivateProduct(productID);
        }

        public List<Product> SearchProducts(string keyword)
        {
            return repository.SearchProducts(keyword);
        }

        public DashboardStats GetDashboardStats()
        {
            return repository.GetDashboardStats();
        }

        public List<LowStockItem> GetLowStockItems()
        {
            return repository.GetLowStockItems();
        }

        private void ValidateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new Exception("Product name is required.");

            if (product.CategoryID <= 0)
                throw new Exception("Please select a category.");

            if (product.SupplierID <= 0)
                throw new Exception("Please select a supplier.");

            if (product.UnitPrice < 0)
                throw new Exception("Unit price cannot be negative.");

            if (product.InitialStock < 0)
                throw new Exception("Initial stock cannot be negative.");

            if (product.ReorderLevel < 0)
                throw new Exception("Reorder level cannot be negative.");
        }
    }
}
