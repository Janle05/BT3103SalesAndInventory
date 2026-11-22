using SalesInventory.Repository;

namespace SalesInventory.businesslogic
{
    public class InventoryService
    {
        private readonly InventoryRepository repository;

        public InventoryService()
        {
            repository = new InventoryRepository();
        }

        public List<InventoryItem> GetInventory(string keyword)
        {
            return repository.GetInventory((keyword ?? "").Trim());
        }

        public void StockIn(int productID, int quantity, string reason, int userID)
        {
            if (productID <= 0)
                throw new Exception("Please select a product first.");

            if (quantity <= 0)
                throw new Exception("Quantity must be greater than zero.");

            repository.ChangeStock(
                productID,
                quantity,
                "Stock In",
                string.IsNullOrWhiteSpace(reason) ? "Stock in" : reason,
                userID);
        }

        public void StockOut(int productID, int quantity, string reason, int userID)
        {
            if (productID <= 0)
                throw new Exception("Please select a product first.");

            if (quantity <= 0)
                throw new Exception("Quantity must be greater than zero.");

            repository.ChangeStock(
                productID,
                -quantity,
                "Stock Out",
                string.IsNullOrWhiteSpace(reason) ? "Stock out" : reason,
                userID);
        }

        public void SetCount(int productID, int newQuantity, string reason, int userID)
        {
            if (productID <= 0)
                throw new Exception("Please select a product first.");

            if (newQuantity < 0)
                throw new Exception("Stock count cannot be negative.");

            repository.SetStock(
                productID,
                newQuantity,
                string.IsNullOrWhiteSpace(reason) ? "Physical count" : reason,
                userID);
        }
    }
}
