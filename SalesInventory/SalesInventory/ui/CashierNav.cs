namespace SalesInventory.ui
{
    // Ipinapatupad ng form na may order na hindi pa bayad, para tanungin muna
    // ang cashier bago siya lumipat ng page.
    public interface ICashierGuard
    {
        bool CanLeave();
    }

    // Sidebar ng Cashier: New Sale, My Sales, Logout.
    // Hinahanap ang mga button base sa TEXT nila (parang NavHelper ng Admin).
    public static class CashierNav
    {
        private static bool isSwitching = false;

        private static readonly string[] Pages = { "New Sale", "My Sales", "Logout" };

        // Tawagin sa constructor:  CashierNav.Wire(this, "New Sale");
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

                btn.Click += (s, e) =>
                {
                    if (text.Equals(currentPage, StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    Go(form, text);
                };
            }
        }

        private static void Go(Form from, string page)
        {
            if (from.IsDisposed)
            {
                return;
            }

            if (from is ICashierGuard guard && !guard.CanLeave())
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
                "New Sale" => new CashierDashboard(),
                "My Sales" => new CashierSalesForm(),
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
