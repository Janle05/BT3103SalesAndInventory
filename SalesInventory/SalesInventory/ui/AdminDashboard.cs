using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}