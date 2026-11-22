using Microsoft.Data.SqlClient;
using SalesInventory.businesslogic;
using SalesInventory.BusinessLogic;

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

            NavHelper.Wire(this, "Categories");
            GridHelper.Apply(dgvCategories);

            ConfigureControls();
            LoadCategories();

            // "-=" muna bago "+=" para hindi tumakbo ng dalawang beses
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

            dgvCategories.CellClick -= dgvCategories_CellClick;
            dgvCategories.CellClick += dgvCategories_CellClick;
        }

        // Dati ay walang laman ang Status dropdown, kaya inayos ito dito
        private void ConfigureControls()
        {
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadCategories()
        {
            try
            {
                dgvCategories.DataSource = null;
                dgvCategories.DataSource = categoryService.GetAllCategories();
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

        private void SelectCategoryRow(int rowIndex)
        {
            if (rowIndex < 0) return;

            DataGridViewRow row = dgvCategories.Rows[rowIndex];

            selectedCategoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);

            txtCategory.Text = row.Cells["CategoryName"].Value?.ToString() ?? "";
            txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";

            string status = row.Cells["Status"].Value?.ToString() ?? "Active";

            if (cmbStatus.Items.Contains(status))
                cmbStatus.SelectedItem = status;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCategoryRow(e.RowIndex);
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
                    Status = string.IsNullOrWhiteSpace(cmbStatus.Text) ? "Active" : cmbStatus.Text
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
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "A category with that name already exists.",
                    "Duplicate Category",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "A category with that name already exists.",
                    "Duplicate Category",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

        // DELETE = i-deactivate lang (hindi binubura) para hindi mag-error
        // kapag may Products na gumagamit ng category.
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
                    "Are you sure you want to deactivate this category?",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                categoryService.DeactivateCategory(selectedCategoryID);

                MessageBox.Show(
                    "Category deactivated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to deactivate category:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    LoadCategories();
                    return;
                }

                var results = categoryService.SearchCategories(keyword);

                dgvCategories.DataSource = null;
                dgvCategories.DataSource = results;
                dgvCategories.ClearSelection();

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

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnCategories_Click(object sender, EventArgs e) { }
        private void btnDashBoard_Click(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e) { }
        private void btnSuppliers_Click(object sender, EventArgs e) { }
        private void btnProducts_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCategoryRow(e.RowIndex);
        }
    }
}
