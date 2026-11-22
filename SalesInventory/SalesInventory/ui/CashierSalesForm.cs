using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class CashierSalesForm : Form
    {
        private readonly CashierService cashierService;

        public CashierSalesForm()
        {
            InitializeComponent();

            cashierService = new CashierService();

            CashierNav.Wire(this, "My Sales");
            GridHelper.Apply(dgvMySales);

            lblWelcome.Text = "Hello, " + (Session.CurrentUser?.Username ?? "Cashier") + "!";
            lblRole.Text = Session.CurrentUser?.Role ?? "Cashier";

            // Default: benta ngayong araw
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;

            btnSearch.Click += btnSearch_Click;
            btnViewReceipt.Click += btnViewReceipt_Click;

            LoadSales(false);
        }

        private void LoadSales(bool showEmptyMessage)
        {
            try
            {
                List<CashierSaleRecord> list =
                    cashierService.GetMySales(Session.UserId, dtpStart.Value, dtpEnd.Value);

                dgvMySales.DataSource = list;
                GridHelper.FormatColumns(dgvMySales);
                dgvMySales.ClearSelection();

                decimal total = 0;

                foreach (CashierSaleRecord sale in list)
                {
                    total += sale.TotalAmount;
                }

                lblTotalSales.Text = "₱ " + total.ToString("N2");
                lblTotalTransactions.Text = list.Count.ToString("N0");

                if (showEmptyMessage && list.Count == 0)
                {
                    MessageBox.Show(
                        "No sales found for the selected dates.",
                        "My Sales",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Load Sales",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadSales(true);
        }

        private void btnViewReceipt_Click(object? sender, EventArgs e)
        {
            if (dgvMySales.SelectedRows.Count == 0 ||
                dgvMySales.SelectedRows[0].DataBoundItem is not CashierSaleRecord sale)
            {
                MessageBox.Show(
                    "Please select a sale from the table first.",
                    "View Receipt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (ReceiptForm receipt = new ReceiptForm(sale.SaleID))
                {
                    receipt.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Open Receipt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
