using SalesInventory.businesslogic;
using System.Drawing.Printing;

namespace SalesInventory.ui
{
    public partial class ReceiptForm : Form
    {
        private readonly string receiptText;

        public ReceiptForm(int saleID)
        {
            InitializeComponent();

            CashierService service = new CashierService();
            ReceiptData data = service.GetReceipt(saleID);

            receiptText = ReceiptBuilder.Build(data);

            this.Text = "Receipt #" + saleID.ToString("D6");

            txtReceipt.Multiline = true;
            txtReceipt.ReadOnly = true;
            txtReceipt.ScrollBars = ScrollBars.Vertical;
            txtReceipt.Font = new Font("Consolas", 10);
            txtReceipt.Text = receiptText;
            txtReceipt.SelectionStart = 0;
            txtReceipt.SelectionLength = 0;

            btnPrint.Click += btnPrint_Click;
            btnClose.Click += btnClose_Click;
        }

        private void btnPrint_Click(object? sender, EventArgs e)
        {
            try
            {
                PrintDocument document = new PrintDocument();

                document.PrintPage += (s, args) =>
                {
                    using (Font font = new Font("Consolas", 9))
                    {
                        args.Graphics?.DrawString(receiptText, font, Brushes.Black, args.MarginBounds);
                    }
                };

                using (PrintPreviewDialog preview = new PrintPreviewDialog())
                {
                    preview.Document = document;
                    preview.Width = 800;
                    preview.Height = 700;
                    preview.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to print:\n" + ex.Message,
                    "Print",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
