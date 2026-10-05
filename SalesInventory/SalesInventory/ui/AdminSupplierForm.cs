using SalesInventory.businesslogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SalesInventory.ui
{
    public partial class AdminSupplierForm : Form
    {
        private void ClearFields()
        {
            selectedSupplierID = 0;
            if (txtSupplierName != null) txtSupplierName.Clear();
            if (txtContactPerson != null) txtContactPerson.Clear();
            if (txtPhone != null) txtPhone.Clear();
            if (txtEmail != null) txtEmail.Clear();
            if (txtAddress != null) txtAddress.Clear();
            if (cmbStatus != null && cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;
            dgvSuppliers.ClearSelection();
        }
        private readonly SupplierService supplierService;
        private int selectedSupplierID = 0;
        public AdminSupplierForm()
        {
            InitializeComponent();

            supplierService = new SupplierService();

            ConfigureControls();
            LoadSuppliers();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
        }

        private void ConfigureControls()
        {
            if (cmbStatus != null)
            {
                cmbStatus.Items.Clear();
                cmbStatus.Items.Add("Active");
                cmbStatus.Items.Add("Inactive");
                cmbStatus.SelectedIndex = 0;
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                dgvSuppliers.DataSource = null;
                dgvSuppliers.DataSource =
                    supplierService.GetAllSuppliers();

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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void AdminSupplierForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier
                {
                    SupplierName = txtSupplierName.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    EmailAddress = txtEmail.Text.Trim(),
                    PhysicalAddress = txtAddress.Text.Trim(),
                    Status = cmbStatus.Text
                };

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

                Supplier supplier = new Supplier
                {
                    SupplierID = selectedSupplierID,
                    SupplierName = txtSupplierName.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    EmailAddress = txtEmail.Text.Trim(),
                    PhysicalAddress = txtAddress.Text.Trim(),
                    Status = cmbStatus.Text
                };

                supplierService.UpdateSupplier(supplier);

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

                supplierService.DeactivateSupplier(
                    selectedSupplierID);

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
            selectedSupplierID = 0;
            if (txtSupplierName != null) txtSupplierName.Clear();
            if (txtContactPerson != null) txtContactPerson.Clear();
            if (txtPhone != null) txtPhone.Clear();
            if (txtEmail != null) txtEmail.Clear();
            if (txtAddress != null) txtAddress.Clear();
            if (cmbStatus != null && cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            dgvSuppliers.ClearSelection();
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];

                // Kinukuha natin ang ID direkta mula sa table papunta sa variable para magamit sa Update/Delete
                selectedSupplierID = Convert.ToInt32(row.Cells["SupplierID"].Value);

                if (txtSupplierName != null) txtSupplierName.Text = row.Cells["SupplierName"].Value?.ToString() ?? "";
                if (txtContactPerson != null) txtContactPerson.Text = row.Cells["ContactPerson"].Value?.ToString() ?? "";
                if (txtPhone != null) txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                if (txtEmail != null) txtEmail.Text = row.Cells["EmailAddress"].Value?.ToString() ?? "";
                if (txtAddress != null) txtAddress.Text = row.Cells["PhysicalAddress"].Value?.ToString() ?? "";

                string status = row.Cells["Status"].Value?.ToString() ?? "Active";
                if (cmbStatus != null && cmbStatus.Items.Contains(status))
                {
                    cmbStatus.SelectedItem = status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AdminCategoryForm categoryForm =
                new AdminCategoryForm();

            categoryForm.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminProductMaintenanceForm productForm =
             new AdminProductMaintenanceForm();

            productForm.Show();

            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to logout?",
               "Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            LoginFrom loginForm =
                Application.OpenForms
                    .OfType<LoginFrom>()
                    .FirstOrDefault();

            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                LoginFrom newLoginForm =
                    new LoginFrom();

                newLoginForm.Show();
            }

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}