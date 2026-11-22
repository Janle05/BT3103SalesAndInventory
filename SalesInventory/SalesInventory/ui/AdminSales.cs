using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class AdminSales : Form
    {
        private readonly SalesService salesService;

        public AdminSales()
        {
            InitializeComponent();

            salesService = new SalesService();

            NavHelper.Wire(this, "Sales");
            GridHelper.Apply(dgvSales);

            // Default: huling 30 araw hanggang ngayon
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Today;

            btnSearch.Click += btnSearch_Click;

            LoadSales(false);
        }

        private void LoadSales(bool showEmptyMessage)
        {
            try
            {
                var list = salesService.GetSales(dtpStart.Value, dtpEnd.Value);

                dgvSales.DataSource = list;
                GridHelper.FormatColumns(dgvSales);
                dgvSales.ClearSelection();

                if (showEmptyMessage && list.Count == 0)
                {
                    MessageBox.Show(
                        "No sales found for the selected dates.",
                        "Sales",
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


        private void AdminSales_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
