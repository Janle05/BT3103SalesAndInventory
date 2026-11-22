using SalesInventory.Repository;

namespace SalesInventory.businesslogic
{
    public class SalesService
    {
        private readonly SalesRepository repository;

        public SalesService()
        {
            repository = new SalesRepository();
        }

        public List<SaleRecord> GetSales(DateTime from, DateTime to)
        {
            ValidateRange(from, to);
            return repository.GetSales(from, to);
        }

        public List<PaymentRecord> GetPayments(DateTime from, DateTime to)
        {
            ValidateRange(from, to);
            return repository.GetPayments(from, to);
        }

        public List<ProductSalesRow> GetProductSales(DateTime from, DateTime to)
        {
            ValidateRange(from, to);
            return repository.GetProductSales(from, to);
        }

        public SalesSummary GetSummary(DateTime from, DateTime to)
        {
            ValidateRange(from, to);
            return repository.GetSummary(from, to);
        }

        private void ValidateRange(DateTime from, DateTime to)
        {
            if (from.Date > to.Date)
            {
                throw new Exception("Start date cannot be later than the end date.");
            }
        }
    }
}
