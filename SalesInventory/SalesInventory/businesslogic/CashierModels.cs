using System.ComponentModel;

namespace SalesInventory.businesslogic
{
    // Isang product sa listahan ng Cashier (kaliwang grid)
    public class ProductForSale
    {
        [DisplayName("ID")]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; } = "";

        [DisplayName("Category")]
        public string CategoryName { get; set; } = "";

        [DisplayName("Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Stock")]
        public int StockQuantity { get; set; }
    }

    // Isang linya sa Current Order (kanang grid)
    public class OrderLine
    {
        [Browsable(false)]
        public int ProductID { get; set; }

        [DisplayName("Product")]
        public string ProductName { get; set; } = "";

        [DisplayName("Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Qty")]
        public int Quantity { get; set; }

        [DisplayName("Subtotal")]
        public decimal Subtotal
        {
            get { return UnitPrice * Quantity; }
        }
    }

    // Mga linya ng resibo
    public class ReceiptItem
    {
        public string ProductName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }

    // Lahat ng datos para sa resibo
    public class ReceiptData
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; } = "";
        public string PaymentMethod { get; set; } = "";
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal ChangeAmount { get; set; }
        public List<ReceiptItem> Items { get; set; } = new List<ReceiptItem>();
    }

    // Laman ng My Sales grid
    public class CashierSaleRecord
    {
        [DisplayName("Sale ID")]
        public int SaleID { get; set; }

        [DisplayName("Date")]
        public DateTime SaleDate { get; set; }

        [DisplayName("Items")]
        public int Items { get; set; }

        [DisplayName("Total Amount")]
        public decimal TotalAmount { get; set; }

        [DisplayName("Payment")]
        public string PaymentMethod { get; set; } = "";
    }
}
