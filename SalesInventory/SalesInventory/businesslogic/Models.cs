using System.ComponentModel;

namespace SalesInventory.businesslogic
{
    public class DashboardStats
    {
        public int TotalProducts { get; set; }
        public int TotalStocks { get; set; }
        public int LowStocks { get; set; }
        public int OutOfStocks { get; set; }
    }

    public class LowStockItem
    {
        [DisplayName("Product ID")]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; } = "";

        [DisplayName("Stock")]
        public int StockQuantity { get; set; }

        [DisplayName("Reorder Level")]
        public int ReorderLevel { get; set; }

        [DisplayName("Status")]
        public string StockStatus { get; set; } = "";
    }

    public class InventoryItem
    {
        [DisplayName("Product ID")]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; } = "";

        [DisplayName("Category")]
        public string CategoryName { get; set; } = "";

        [DisplayName("Stock")]
        public int StockQuantity { get; set; }

        [DisplayName("Reorder Level")]
        public int ReorderLevel { get; set; }

        [DisplayName("Status")]
        public string StockStatus { get; set; } = "";
    }

    public class SaleRecord
    {
        [DisplayName("Sale ID")]
        public int SaleID { get; set; }

        [DisplayName("Date")]
        public DateTime SaleDate { get; set; }

        [DisplayName("Cashier")]
        public string Cashier { get; set; } = "";

        [DisplayName("Items")]
        public int Items { get; set; }

        [DisplayName("Total Amount")]
        public decimal TotalAmount { get; set; }
    }

    public class PaymentRecord
    {
        [DisplayName("Payment ID")]
        public int PaymentID { get; set; }

        [DisplayName("Sale ID")]
        public int SaleID { get; set; }

        [DisplayName("Date")]
        public DateTime PaymentDate { get; set; }

        [DisplayName("Method")]
        public string PaymentMethod { get; set; } = "";

        [DisplayName("Amount Paid")]
        public decimal AmountPaid { get; set; }

        [DisplayName("Change")]
        public decimal ChangeAmount { get; set; }
    }

    public class ProductSalesRow
    {
        [DisplayName("Product Name")]
        public string ProductName { get; set; } = "";

        [DisplayName("Quantity Sold")]
        public int QuantitySold { get; set; }

        [DisplayName("Revenue")]
        public decimal Revenue { get; set; }
    }

    public class SalesSummary
    {
        public decimal TotalSales { get; set; }
        public int TotalTransactions { get; set; }
    }
}
