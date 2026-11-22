using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class AdminDashboard : Form
    {
        private readonly ProductService productService;

        public AdminDashboard()
        {
            InitializeComponent();

            productService = new ProductService();

            NavHelper.Wire(this, "Dashboard");
            GridHelper.Apply(dgvLowStock);

          
            this.Load -= AdminDashboard_Load;
            this.Load += AdminDashboard_Load;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadWelcome();
            LoadStats();
            LoadLowStock();
        }

        private void LoadWelcome()
        {
            string username = Session.CurrentUser?.Username ?? "Admin";
            string role = Session.CurrentUser?.Role ?? "Admin";

            lblWelcome.Text = "Hello, " + username + "!";
            lblRole.Text = role;
        }

        private void LoadStats()
        {
            try
            {
                DashboardStats stats = productService.GetDashboardStats();

                lblTotalProducts.Text = stats.TotalProducts.ToString("N0");
                lblTotalStocks.Text = stats.TotalStocks.ToString("N0");
                lblLowStocks.Text = stats.LowStocks.ToString("N0");
                lblOutOfStocks.Text = stats.OutOfStocks.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading dashboard:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadLowStock()
        {
            try
            {
                dgvLowStock.DataSource = productService.GetLowStockItems();
                dgvLowStock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading low stock list:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e) { }
        private void btnCategories_Click(object sender, EventArgs e) { }
        private void btnSuppliers_Click(object sender, EventArgs e) { }
        private void btnProducts_Click(object sender, EventArgs e) { }
        private void btnSales_Click(object sender, EventArgs e) { }
        private void btnInventory_Click(object sender, EventArgs e) { }
        private void btnPayments_Click(object sender, EventArgs e) { }
        private void btnReports_Click(object sender, EventArgs e) { }

        private void lblTotalStocks_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
