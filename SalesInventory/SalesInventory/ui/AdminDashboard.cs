namespace SalesInventory.ui
{
    public partial class AdminDashboard : Form
    {
        private bool isLoggingOut = false;

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?\nYou will be returned to the login screen.",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            isLoggingOut = true;

            LoginFrom? loginForm = Application.OpenForms.OfType<LoginFrom>().FirstOrDefault();

            if (loginForm != null)
            {
                loginForm.ResetForm();
                loginForm.Show();
            }
            else
            {
                new LoginFrom().Show();
            }

            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AdminCategoryForm categoryForm = new AdminCategoryForm();
            categoryForm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            AdminSupplierForm Supplier = new AdminSupplierForm();
            Supplier.Show();

            this.Close();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AdminProductMaintenanceForm productForm = new AdminProductMaintenanceForm();
            productForm.Show();
        }
    }
}