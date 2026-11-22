using SalesInventory.Repository;

namespace SalesInventory.businesslogic
{
    public class CashierService
    {
        private readonly CashierRepository repository;

        public CashierService()
        {
            repository = new CashierRepository();
        }

        public List<ProductForSale> GetProductsForSale(string keyword, int categoryID)
        {
            return repository.GetProductsForSale((keyword ?? "").Trim(), categoryID);
        }

        public int CreateSale(int cashierID, List<OrderLine> lines, string paymentMethod, decimal amountPaid)
        {
            if (cashierID <= 0)
                throw new Exception("No cashier is logged in. Please log in again.");

            if (lines == null || lines.Count == 0)
                throw new Exception("The order is empty.");

            foreach (OrderLine line in lines)
            {
                if (line.Quantity <= 0)
                    throw new Exception("Invalid quantity for \"" + line.ProductName + "\".");
            }

            if (string.IsNullOrWhiteSpace(paymentMethod))
                throw new Exception("Please select a payment method.");

            return repository.CreateSale(cashierID, lines, paymentMethod.Trim(), amountPaid);
        }

        public ReceiptData GetReceipt(int saleID)
        {
            if (saleID <= 0)
                throw new Exception("Invalid sale number.");

            return repository.GetReceipt(saleID);
        }

        public List<CashierSaleRecord> GetMySales(int cashierID, DateTime from, DateTime to)
        {
            if (from.Date > to.Date)
                throw new Exception("Start date cannot be later than the end date.");

            return repository.GetSalesByCashier(cashierID, from, to);
        }
    }
}
