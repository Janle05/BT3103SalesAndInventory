using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class AdminSupplierForm : Form
    {
        private readonly SupplierService supplierService;
        private int selectedSupplierID = 0;

        public AdminSupplierForm()
        {
            InitializeComponent();

            supplierService = new SupplierService();

            NavHelper.Wire(this, "Suppliers");
            GridHelper.Apply(dgvSuppliers);

            ConfigureControls();
            LoadSuppliers();

            // "-=" muna bago "+=" para hindi tumakbo ng dalawang beses
            // kahit naka-wire din ang button sa Designer.
            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            btnSearch.Click -= btnSearch_Click;
            btnSearch.Click += btnSearch_Click;

            dgvSuppliers.CellClick -= dgvSuppliers_CellClick;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
        }

        private void ConfigureControls()
        {
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadSuppliers()
        {
            try
            {
                dgvSuppliers.DataSource = null;
                dgvSuppliers.DataSource = supplierService.GetAllSuppliers();
                dgvSuppliers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading suppliers:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            selectedSupplierID = 0;

            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            dgvSuppliers.ClearSelection();
        }

        private Supplier ReadForm()
        {
            return new Supplier
            {
                SupplierID = selectedSupplierID,
                SupplierName = txtSupplierName.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                EmailAddress = txtEmail.Text.Trim(),
                PhysicalAddress = txtAddress.Text.Trim(),
                Status = cmbStatus.Text
            };
        }

        private void SelectSupplierRow(int rowIndex)
        {
            if (rowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvSuppliers.Rows[rowIndex];

                selectedSupplierID = Convert.ToInt32(row.Cells["SupplierID"].Value);

                txtSupplierName.Text = row.Cells["SupplierName"].Value?.ToString() ?? "";
                txtContactPerson.Text = row.Cells["ContactPerson"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["EmailAddress"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["PhysicalAddress"].Value?.ToString() ?? "";

                string status = row.Cells["Status"].Value?.ToString() ?? "Active";

                if (cmbStatus.Items.Contains(status))
                    cmbStatus.SelectedItem = status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error selecting row:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSupplierRow(e.RowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = ReadForm();
                supplier.SupplierID = 0;

                supplierService.AddSupplier(supplier);

                MessageBox.Show(
                    "Supplier added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSuppliers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Add Supplier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSupplierID == 0)
                {
                    MessageBox.Show(
                        "Please select a supplier first.",
                        "Update Supplier",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                supplierService.UpdateSupplier(ReadForm());

                MessageBox.Show(
                    "Supplier updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSuppliers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Update Supplier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSupplierID == 0)
                {
                    MessageBox.Show(
                        "Please select a supplier first.",
                        "Deactivate Supplier",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to deactivate this supplier?",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                supplierService.DeactivateSupplier(selectedSupplierID);

                MessageBox.Show(
                    "Supplier deactivated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSuppliers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Deactivate Supplier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var results = supplierService.SearchSuppliers(txtSearch.Text);

                dgvSuppliers.DataSource = null;
                dgvSuppliers.DataSource = results;
                dgvSuppliers.ClearSelection();

                if (results.Count == 0)
                {
                    MessageBox.Show(
                        "No supplier found.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e) { }
        private void AdminSupplierForm_Load(object sender, EventArgs e) { }
        private void btnCategories_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSupplierRow(e.RowIndex);
        }
    }
}
