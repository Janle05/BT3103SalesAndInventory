using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class AdminPayment : Form
    {
        private readonly SalesService salesService;

        public AdminPayment()
        {
            InitializeComponent();

            salesService = new SalesService();

            NavHelper.Wire(this, "Payments");
            GridHelper.Apply(dgvPayments);

            // Default: huling 30 araw hanggang ngayon
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Today;

            btnSearch.Click += btnSearch_Click;

            LoadPayments(false);
        }

        private void LoadPayments(bool showEmptyMessage)
        {
            try
            {
                var list = salesService.GetPayments(dtpStart.Value, dtpEnd.Value);

                dgvPayments.DataSource = list;
                GridHelper.FormatColumns(dgvPayments);
                dgvPayments.ClearSelection();

                if (showEmptyMessage && list.Count == 0)
                {
                    MessageBox.Show(
                        "No payment records found for the selected dates.",
                        "Payments",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Load Payments",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadPayments(true);
        }

        
        private void AdminPayment_Load(object sender, EventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }
    }
}
