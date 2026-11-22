using System.Text;

namespace SalesInventory.businesslogic
{
    // Ginagawang text ang ReceiptData (40 characters ang lapad, pang-thermal printer)
    public static class ReceiptBuilder
    {
        private const int Width = 40;

        public static string Build(ReceiptData r)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Center("SALES AND INVENTORY SYSTEM"));
            sb.AppendLine(Center("OFFICIAL RECEIPT"));
            sb.AppendLine(new string('=', Width));
            sb.AppendLine("Receipt #: " + r.SaleID.ToString("D6"));
            sb.AppendLine("Date     : " + r.SaleDate.ToString("yyyy-MM-dd hh:mm tt"));
            sb.AppendLine("Cashier  : " + r.Cashier);
            sb.AppendLine(new string('-', Width));

            foreach (ReceiptItem item in r.Items)
            {
                sb.AppendLine(Cut(item.ProductName, Width));

                string left = "  " + item.Quantity + " x " + item.UnitPrice.ToString("N2");
                sb.AppendLine(Line(left, item.LineTotal.ToString("N2")));
            }

            sb.AppendLine(new string('-', Width));
            sb.AppendLine(Line("TOTAL", "PHP " + r.TotalAmount.ToString("N2")));
            sb.AppendLine(Line("Paid (" + r.PaymentMethod + ")", "PHP " + r.AmountPaid.ToString("N2")));
            sb.AppendLine(Line("Change", "PHP " + r.ChangeAmount.ToString("N2")));
            sb.AppendLine(new string('=', Width));
            sb.AppendLine(Center("Thank you! Please come again."));

            return sb.ToString();
        }

        private static string Line(string left, string right)
        {
            int spaces = Width - left.Length - right.Length;

            if (spaces < 1)
            {
                spaces = 1;
            }

            return left + new string(' ', spaces) + right;
        }

        private static string Center(string text)
        {
            if (text.Length >= Width)
            {
                return text;
            }

            int pad = (Width - text.Length) / 2;
            return new string(' ', pad) + text;
        }

        private static string Cut(string text, int max)
        {
            return text.Length <= max ? text : text.Substring(0, max);
        }
    }
}
