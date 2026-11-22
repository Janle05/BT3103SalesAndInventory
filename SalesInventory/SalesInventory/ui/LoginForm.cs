using SalesInventory.businesslogic;
using SalesInventory.ui;

namespace SalesInventory
{
    public partial class LoginFrom : Form
    {
        private readonly LoginService loginService;

        public LoginFrom()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                User? user = loginService.Login(username, password);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Itago kung sino ang naka-login (gagamitin sa Dashboard at Inventory)
                Session.CurrentUser = user;

                if (user.Role == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (user.Role == "Cashier")
                {
                    CashierDashboard cashierDashboard = new CashierDashboard();
                    cashierDashboard.Show();
                    this.Hide();
                }
                else
                {
                    Session.Clear();
                    MessageBox.Show("Unauthorized role.", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to login:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}