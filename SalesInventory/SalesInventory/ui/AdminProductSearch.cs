using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesInventory.ui
{
    public partial class AdminProductSearch : Form
    {
        public AdminProductSearch()
        {
            InitializeComponent();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            AdminPayment paymentForm = new AdminPayment();
            paymentForm.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AdminReports adminReports = new AdminReports();
            adminReports.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }
    }
}
