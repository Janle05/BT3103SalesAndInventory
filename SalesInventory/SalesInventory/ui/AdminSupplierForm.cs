using System;
using System.Windows.Forms;
using SalesInventory.BusinessLogic;

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

            // Status options
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedIndex = 0;

            // Connect buttons to their events
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            // Connect table selection
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Load suppliers when the form opens
            this.Load += AdminSupplierForm_Load;
        }

        private void AdminSupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            ClearFields();
        }

        private void LoadSuppliers()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = supplierService.GetSuppliers();

                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load suppliers.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private SalesInventory.BusinessLogic.Supplier GetSupplierFromFields()
        {
            return new SalesInventory.BusinessLogic.Supplier
            {
                SupplierID = selectedSupplierID,
                SupplierName = txtSupplierName.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Status = cmbStatus.Text
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = GetSupplierFromFields();

                // A new supplier should have ID 0
                supplier.SupplierID = 0;

                supplierService.SaveSupplier(supplier);

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
            if (selectedSupplierID == 0)
            {
                MessageBox.Show("Please select a supplier from the table first.");
                return;
            }

            try
            {
                var supplier = GetSupplierFromFields();

                supplierService.SaveSupplier(supplier);

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
            if (selectedSupplierID == 0)
            {
                MessageBox.Show("Please select a supplier from the table first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this supplier?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
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
                    "Failed to deactivate supplier.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource =
                    supplierService.SearchSuppliers(txtSearch.Text.Trim());

                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadSuppliers();
        }

        private void ClearFields()
        {
            selectedSupplierID = 0;

            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSearch.Clear();

            cmbStatus.SelectedIndex = 0;

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.Cells["SupplierID"].Value == null)
            {
                return;
            }

            selectedSupplierID =
                Convert.ToInt32(row.Cells["SupplierID"].Value);

            txtSupplierName.Text =
                row.Cells["SupplierName"].Value?.ToString() ?? "";

            txtContactPerson.Text =
                row.Cells["ContactPerson"].Value?.ToString() ?? "";

            txtPhone.Text =
                row.Cells["Phone"].Value?.ToString() ?? "";

            txtEmail.Text =
                row.Cells["Email"].Value?.ToString() ?? "";

            txtAddress.Text =
                row.Cells["Address"].Value?.ToString() ?? "";

            cmbStatus.Text =
                row.Cells["Status"].Value?.ToString() ?? "Active";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Existing Transactions navigation event.
        }

        private void AdminSupplierForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}