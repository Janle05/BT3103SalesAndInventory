namespace SalesInventory.ui
{
   
    public static class InputDialogs
    {
        public static (bool Ok, int Quantity, string Reason) AskQuantity(
            string title,
            string message,
            int minimum,
            int maximum,
            int startValue,
            string defaultReason)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = title;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.ShowInTaskbar = false;
                dialog.ClientSize = new Size(390, 220);

                Label lblMessage = new Label
                {
                    Text = message,
                    Left = 15,
                    Top = 15,
                    Width = 360,
                    Height = 55
                };

                Label lblQuantity = new Label
                {
                    Text = "Quantity:",
                    Left = 15,
                    Top = 78,
                    Width = 80
                };

                int safeStart = Math.Min(Math.Max(startValue, minimum), maximum);

                NumericUpDown numQuantity = new NumericUpDown
                {
                    Left = 100,
                    Top = 75,
                    Width = 130,
                    Minimum = minimum,
                    Maximum = maximum,
                    Value = safeStart
                };

                Label lblReason = new Label
                {
                    Text = "Reason:",
                    Left = 15,
                    Top = 118,
                    Width = 80
                };

                TextBox txtReason = new TextBox
                {
                    Left = 100,
                    Top = 115,
                    Width = 275,
                    Text = defaultReason
                };

                Button btnOk = new Button
                {
                    Text = "OK",
                    Left = 205,
                    Top = 170,
                    Width = 80,
                    DialogResult = DialogResult.OK
                };

                Button btnCancel = new Button
                {
                    Text = "Cancel",
                    Left = 295,
                    Top = 170,
                    Width = 80,
                    DialogResult = DialogResult.Cancel
                };

                dialog.Controls.Add(lblMessage);
                dialog.Controls.Add(lblQuantity);
                dialog.Controls.Add(numQuantity);
                dialog.Controls.Add(lblReason);
                dialog.Controls.Add(txtReason);
                dialog.Controls.Add(btnOk);
                dialog.Controls.Add(btnCancel);

                dialog.AcceptButton = btnOk;
                dialog.CancelButton = btnCancel;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return (true, (int)numQuantity.Value, txtReason.Text.Trim());
                }

                return (false, 0, "");
            }
        }
    }
}
