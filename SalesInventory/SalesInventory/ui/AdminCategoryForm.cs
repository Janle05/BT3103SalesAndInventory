using SalesInventory.businesslogic;
using SalesInventory.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SalesInventory.ui
{
    public partial class AdminCategoryForm : Form
    {
        private readonly CategoryService categoryService;
        private int selectedCategoryID = 0;
        public AdminCategoryForm()
        {
            InitializeComponent();

            categoryService = new CategoryService();

            LoadCategories();
        }
        private void LoadCategories()
        {
            try
            {
                dgvCategories.DataSource =
                    categoryService.GetAllCategories();

                dgvCategories.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading categories:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void ClearFields()
        {
            selectedCategoryID = 0;

            txtCategory.Clear();
            txtDescription.Clear();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            dgvCategories.ClearSelection();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvCategories.Rows[e.RowIndex];

            selectedCategoryID =
                Convert.ToInt32(
                    row.Cells["CategoryID"].Value);

            txtCategory.Text =
                row.Cells["CategoryName"].Value?.ToString();

            txtDescription.Text =
                row.Cells["Description"].Value?.ToString();

            cmbStatus.Text =
                row.Cells["Status"].Value?.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategory.Text))
                {
                    MessageBox.Show(
                        "Please enter a category name.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Category category = new Category
                {
                    CategoryName = txtCategory.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Status = string.IsNullOrWhiteSpace(cmbStatus.Text)
                        ? "Active"
                        : cmbStatus.Text
                };

                categoryService.AddCategory(category);

                MessageBox.Show(
                    "Category added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add category:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategoryID == 0)
                {
                    MessageBox.Show(
                        "Please select a category first.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCategory.Text))
                {
                    MessageBox.Show(
                        "Please enter a category name.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Category category = new Category
                {
                    CategoryID = selectedCategoryID,
                    CategoryName = txtCategory.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Status = cmbStatus.Text
                };

                categoryService.UpdateCategory(category);

                MessageBox.Show(
                    "Category updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update category:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategoryID == 0)
                {
                    MessageBox.Show(
                        "Please select a category first.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this category?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    categoryService.DeleteCategory(selectedCategoryID);

                    MessageBox.Show(
                        "Category deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearFields();
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete category:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedCategoryID = 0;

            txtCategory.Clear();
            txtDescription.Clear();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            dgvCategories.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    LoadCategories();
                    return;
                }

                var results =
                    categoryService.SearchCategories(keyword);

                dgvCategories.DataSource = results;

                if (results.Count == 0)
                {
                    MessageBox.Show(
                        "No matching category found.",
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

        private void btnCategories_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();

            this.Close();
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
    }
}
