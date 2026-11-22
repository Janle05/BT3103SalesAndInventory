namespace SalesInventory.ui
{
   
    public static class NavHelper
    {
        private static bool isSwitching = false;

        private static readonly string[] Pages =
        {
            "Dashboard", "Suppliers", "Categories", "Products", "Inventory",
            "Payments", "Sales", "Reports", "Logout"
        };

       
        public static void Wire(Form form, string currentPage)
        {
           
            form.FormClosed += (s, e) =>
            {
                if (!isSwitching)
                {
                    Application.Exit();
                }
            };

            foreach (Button btn in GetButtons(form))
            {
                string text = btn.Text.Trim();

                if (!Array.Exists(Pages, p => p.Equals(text, StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }

                
                string target = text;

                btn.Click += (s, e) =>
                {
                    if (target.Equals(currentPage, StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    Go(form, target);
                };
            }
        }

        private static void Go(Form from, string page)
        {
            if (from.IsDisposed)
            {
                return;
            }

            if (page.Equals("Logout", StringComparison.OrdinalIgnoreCase))
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

                Session.Clear();
                isSwitching = true;

                try
                {
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

                    from.Close();
                }
                finally
                {
                    isSwitching = false;
                }

                return;
            }

            Form? next = page switch
            {
                "Dashboard" => new AdminDashboard(),
                "Suppliers" => new AdminSupplierForm(),
                "Categories" => new AdminCategoryForm(),
                "Products" => new AdminProductMaintenanceForm(),
                "Inventory" => new InventoryManagement(),
                "Payments" => new AdminPayment(),
                "Sales" => new AdminSales(),
                "Reports" => new AdminReports(),
                _ => null
            };

            if (next == null)
            {
                return;
            }

            isSwitching = true;

            try
            {
                next.Show();
                from.Close();
            }
            finally
            {
                isSwitching = false;
            }
        }

        private static IEnumerable<Button> GetButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button b)
                {
                    yield return b;
                }

                foreach (Button child in GetButtons(c))
                {
                    yield return child;
                }
            }
        }
    }
}
