using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class AdminReports : Form
    {
        private readonly SalesService salesService;

        public AdminReports()
        {
            InitializeComponent();

            salesService = new SalesService();

            NavHelper.Wire(this, "Reports");
            GridHelper.Apply(dgvReport);

            // Default: huling 30 araw hanggang ngayon
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Today;

            btnGenerate.Click += btnGenerate_Click;

            GenerateReport(false);
        }

        private void GenerateReport(bool showEmptyMessage)
        {
            try
            {
                var rows = salesService.GetProductSales(dtpStart.Value, dtpEnd.Value);
                SalesSummary summary = salesService.GetSummary(dtpStart.Value, dtpEnd.Value);

                dgvReport.DataSource = rows;
                GridHelper.FormatColumns(dgvReport);
                dgvReport.ClearSelection();

                lblTotalSales.Text = "\u20B1 " + summary.TotalSales.ToString("N2");
                lblTotalTransactions.Text = summary.TotalTransactions.ToString("N0");

                if (showEmptyMessage && rows.Count == 0)
                {
                    MessageBox.Show(
                        "No sales found for the selected dates.",
                        "Reports",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Generate Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnGenerate_Click(object? sender, EventArgs e)
        {
            GenerateReport(true);
        }

        private void btnDashboard_Click(object sender, EventArgs e) { }
    }
}
