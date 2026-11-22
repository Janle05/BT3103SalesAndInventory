namespace SalesInventory.ui
{
    public partial class PaymentForm : Form
    {
        private readonly decimal totalAmount;
        private bool isUpdating = false;

        // Binabasa ng CashierDashboard pagkatapos mag-OK
        public string PaymentMethod { get; private set; } = "Cash";
        public decimal AmountPaid { get; private set; }
        public decimal ChangeAmount { get; private set; }

        public PaymentForm(decimal total)
        {
            InitializeComponent();

            totalAmount = total;

            lblTotalAmount.Text = "₱ " + total.ToString("N2");

            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.Items.Clear();
            cmbMethod.Items.Add("Cash");
            cmbMethod.Items.Add("GCash");
            cmbMethod.SelectedIndex = 0;

            numAmountReceived.DecimalPlaces = 2;
            numAmountReceived.Minimum = 0;
            numAmountReceived.Maximum = 99999999;
            numAmountReceived.Value = Math.Min(total, numAmountReceived.Maximum);

            btnCancel.DialogResult = DialogResult.Cancel;
            this.AcceptButton = btnConfirm;
            this.CancelButton = btnCancel;

            cmbMethod.SelectedIndexChanged += cmbMethod_SelectedIndexChanged;
            numAmountReceived.ValueChanged += numAmountReceived_ValueChanged;
            btnConfirm.Click += btnConfirm_Click;

            UpdateChange();
        }

        private void cmbMethod_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateChange();
        }

        private void numAmountReceived_ValueChanged(object? sender, EventArgs e)
        {
            UpdateChange();
        }

        private void UpdateChange()
        {
            if (isUpdating)
                return;

            isUpdating = true;

            try
            {
                bool isCash = cmbMethod.Text == "Cash";

                if (!isCash)
                {
                    // GCash: eksaktong halaga lang
                    numAmountReceived.Value = Math.Min(totalAmount, numAmountReceived.Maximum);
                }

                numAmountReceived.Enabled = isCash;

                decimal paid = numAmountReceived.Value;

                if (paid >= totalAmount)
                {
                    lblChange.Text = "₱ " + (paid - totalAmount).ToString("N2");
                    lblChange.ForeColor = Color.Green;
                }
                else
                {
                    lblChange.Text = "₱ 0.00";
                    lblChange.ForeColor = Color.Red;
                }
            }
            finally
            {
                isUpdating = false;
            }
        }

        private void btnConfirm_Click(object? sender, EventArgs e)
        {
            decimal paid = numAmountReceived.Value;

            if (paid < totalAmount)
            {
                MessageBox.Show(
                    "The amount received is less than the total.",
                    "Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                numAmountReceived.Focus();
                return;
            }

            PaymentMethod = cmbMethod.Text;
            AmountPaid = paid;
            ChangeAmount = paid - totalAmount;

            this.DialogResult = DialogResult.OK;
        }
    }
}
