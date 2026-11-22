using SalesInventory.businesslogic;
using SalesInventory.Repository;

namespace SalesInventory.ui
{
    public partial class AdminProductMaintenanceForm : Form
    {
        private readonly ProductService productService;
        private int selectedProductID = 0;

        public AdminProductMaintenanceForm()
        {
            InitializeComponent();

            productService = new ProductService();

            NavHelper.Wire(this, "Products");

            ConfigureControls();

            LoadCategories();
            LoadSuppliers();
            LoadProducts();

            // "-=" muna bago "+=" para hindi tumakbo ng dalawang beses
            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            button11.Click -= button11_Click;
            button11.Click += button11_Click;

            dgvProducts.CellClick -= dgvProducts_CellClick;
            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        private void ConfigureControls()
        {
            // Product ID ay galing sa database
            textBox2.ReadOnly = true;

            // Status
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Active");
            comboBox2.Items.Add("Inactive");
            comboBox2.SelectedIndex = 0;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            // Hindi pwedeng negative
            numericUpDown1.Minimum = 0;
            numericUpDown2.Minimum = 0;
            numericUpDown3.Minimum = 0;

            // Unit Price
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Maximum = 999999999;

            // Initial Stock / Stock
            numericUpDown2.Maximum = 999999999;

            // Reorder Level
            numericUpDown3.Maximum = 999999999;
        }

        private void LoadProducts()
        {
            try
            {
                dgvProducts.Columns.Clear();
                dgvProducts.AutoGenerateColumns = false;

                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProductID", HeaderText = "Product ID", DataPropertyName = "ProductID", Width = 80 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProductName", HeaderText = "Product Name", DataPropertyName = "ProductName", Width = 150 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "CategoryID", HeaderText = "Category ID", DataPropertyName = "CategoryID", Width = 90 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "SupplierID", HeaderText = "Supplier ID", DataPropertyName = "SupplierID", Width = 90 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "UnitPrice", HeaderText = "Unit Price", DataPropertyName = "UnitPrice", Width = 90 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "StockQuantity", HeaderText = "Stock Quantity", DataPropertyName = "StockQuantity", Width = 100 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReorderLevel", HeaderText = "Reorder Level", DataPropertyName = "ReorderLevel", Width = 90 });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", Width = 80 });

                dgvProducts.ReadOnly = true;
                dgvProducts.AllowUserToAddRows = false;
                dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProducts.MultiSelect = false;

                dgvProducts.ForeColor = Color.Black;
                dgvProducts.DefaultCellStyle.ForeColor = Color.Black;
                dgvProducts.DefaultCellStyle.BackColor = Color.White;
                dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Navy;

                dgvProducts.DataSource = productService.GetAllProducts();
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading products:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                CategoryRepository repository = new CategoryRepository();

                comboBox1.DataSource = null;
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryID";
                comboBox1.DataSource = repository.GetAllCategories();
                comboBox1.SelectedIndex = -1;
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

        private void LoadSuppliers()
        {
            try
            {
                SupplierRepository repository = new SupplierRepository();

                comboBox3.DataSource = null;
                comboBox3.DisplayMember = "SupplierName";
                comboBox3.ValueMember = "SupplierID";
                comboBox3.DataSource = repository.GetAllSuppliers();
                comboBox3.SelectedIndex = -1;
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

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Product name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return false;
            }

            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox3.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                Product product = new Product
                {
                    ProductName = textBox1.Text.Trim(),
                    CategoryID = Convert.ToInt32(comboBox1.SelectedValue),
                    SupplierID = Convert.ToInt32(comboBox3.SelectedValue),
                    UnitPrice = numericUpDown1.Value,
                    InitialStock = Convert.ToInt32(numericUpDown2.Value),
                    ReorderLevel = Convert.ToInt32(numericUpDown3.Value),
                    Status = comboBox2.Text
                };

                productService.AddProduct(product);

                MessageBox.Show(
                    "Product added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding product:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductID == 0)
                {
                    MessageBox.Show(
                        "Please select a product from the table first.",
                        "Update Product",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!ValidateInputs())
                    return;

                // Hindi na ginagalaw ng Update ang stock.
                // Para baguhin ang stock, gamitin ang Inventory page.
                Product product = new Product
                {
                    ProductID = selectedProductID,
                    ProductName = textBox1.Text.Trim(),
                    CategoryID = Convert.ToInt32(comboBox1.SelectedValue),
                    SupplierID = Convert.ToInt32(comboBox3.SelectedValue),
                    UnitPrice = numericUpDown1.Value,
                    ReorderLevel = Convert.ToInt32(numericUpDown3.Value),
                    Status = comboBox2.Text
                };

                productService.UpdateProduct(product);

                MessageBox.Show(
                    "Product updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating product:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductID == 0)
                {
                    MessageBox.Show(
                        "Please select a product first.",
                        "Deactivate Product",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to deactivate this product?",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                productService.DeactivateProduct(selectedProductID);

                MessageBox.Show(
                    "Product deactivated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deactivating product:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SEARCH button
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearchProduct.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    LoadProducts();
                    return;
                }

                var results = productService.SearchProducts(keyword);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = results;
                dgvProducts.ClearSelection();

                if (results.Count == 0)
                {
                    MessageBox.Show(
                        "No product found.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching products:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SelectProductRow(int rowIndex)
        {
            try
            {
                if (rowIndex < 0)
                    return;

                DataGridViewRow row = dgvProducts.Rows[rowIndex];

                if (row.Cells["ProductID"].Value == null)
                    return;

                selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);

                textBox2.Text = selectedProductID.ToString();
                textBox1.Text = row.Cells["ProductName"].Value?.ToString() ?? "";

                numericUpDown1.Value = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                numericUpDown2.Value = Convert.ToDecimal(row.Cells["StockQuantity"].Value);
                numericUpDown3.Value = Convert.ToDecimal(row.Cells["ReorderLevel"].Value);

                // Ang stock ay babaguhin lang sa Inventory page, hindi dito
                numericUpDown2.Enabled = false;

                string status = row.Cells["Status"].Value?.ToString() ?? "Active";

                if (comboBox2.Items.Contains(status))
                    comboBox2.SelectedItem = status;

                comboBox1.SelectedValue = Convert.ToInt32(row.Cells["CategoryID"].Value);
                comboBox3.SelectedValue = Convert.ToInt32(row.Cells["SupplierID"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error selecting product:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProductRow(e.RowIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedProductID = 0;

            textBox2.Clear();
            textBox1.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;

            // Pwede na ulit lagyan ng Initial Stock kapag bagong product
            numericUpDown2.Enabled = true;

            dgvProducts.ClearSelection();
        }

        private void AdminProductMaintenanceForm_Load(object sender, EventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }
        private void btnCategories_Click(object sender, EventArgs e) { }
        private void btnSuppliers_Click(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e) { }
        private void btnProducts_Click(object sender, EventArgs e) { }
        private void btnInventory_Click(object sender, EventArgs e) { }
        private void btnSales_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProductRow(e.RowIndex);
        }
    }
}
