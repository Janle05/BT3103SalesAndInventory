namespace SalesInventory.ui
{
    // Nagtatago o nagpapakita ng "Status" dropdown KASAMA ang label na "Status" nito.
    public static class FormHelper
    {
        public static void ShowStatus(Control root, ComboBox statusCombo, bool visible)
        {
            statusCombo.Visible = visible;

            foreach (Label lbl in FindLabels(root))
            {
                if (lbl.Text.Trim().Equals("Status", StringComparison.OrdinalIgnoreCase))
                {
                    lbl.Visible = visible;
                }
            }
        }

        private static IEnumerable<Label> FindLabels(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label l)
                {
                    yield return l;
                }

                foreach (Label child in FindLabels(c))
                {
                    yield return child;
                }
            }
        }
    }
}
