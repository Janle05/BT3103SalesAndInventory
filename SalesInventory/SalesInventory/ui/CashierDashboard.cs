using SalesInventory.businesslogic;
using SalesInventory.Repository;
using System.ComponentModel;

namespace SalesInventory.ui
{
    public partial class CashierDashboard : Form, ICashierGuard
    {
        private readonly CashierService cashierService;

        // Ang laman ng "Current Order" na grid
        private readonly BindingList<OrderLine> order = new BindingList<OrderLine>();

        private bool isLoadingCategories = false;

        public CashierDashboard()
        {
            InitializeComponent();

            cashierService = new CashierService();

            CashierNav.Wire(this, "New Sale");
            GridHelper.Apply(dgvProducts);
            GridHelper.Apply(dgvOrder);

            dgvOrder.DataSource = order;
            GridHelper.FormatColumns(dgvOrder);

            numQuantity.Minimum = 1;
            numQuantity.Maximum = 9999;
            numQuantity.Value = 1;

            

            LoadCategories();
            LoadProducts();
            UpdateTotals();

            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += txtSearch_KeyDown;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

            btnAddToOrder.Click += btnAddToOrder_Click;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;

            btnRemoveItem.Click += btnRemoveItem_Click;
            btnClearOrder.Click += btnClearOrder_Click;
            btnNewSale.Click += btnNewSale_Click;
            btnCheckout.Click += btnCheckout_Click;
        }

        // ------------------------------------------------------------------
        // PAG-LOAD NG DATA
        // ------------------------------------------------------------------
        private void LoadCategories()
        {
            isLoadingCategories = true;

            try
            {
                List<Category> categories = new List<Category>();
                categories.Add(new Category { CategoryID = 0, CategoryName = "All Categories" });

                CategoryRepository repository = new CategoryRepository();

                foreach (Category c in repository.GetAllCategories())
                {
                    if (c.Status == "Active")
                    {
                        categories.Add(c);
                    }
                }

                cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.DataSource = categories;
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading categories:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                isLoadingCategories = false;
            }
        }

        private void LoadProducts()
        {
            try
            {
                int categoryID = cmbCategory.SelectedValue is int id ? id : 0;

                dgvProducts.DataSource = cashierService.GetProductsForSale(txtSearch.Text, categoryID);
                GridHelper.FormatColumns(dgvProducts);
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

        // ------------------------------------------------------------------
        // SEARCH AT CATEGORY
        // ------------------------------------------------------------------
        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadProducts();
            }
        }

        private void cmbCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (isLoadingCategories)
                return;

            LoadProducts();
        }

        // ------------------------------------------------------------------
        // CURRENT ORDER
        // ------------------------------------------------------------------
        private void dgvProducts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AddSelectedToOrder();
            }
        }

        private void btnAddToOrder_Click(object? sender, EventArgs e)
        {
            AddSelectedToOrder();
        }

        private void AddSelectedToOrder()
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a product from the list first.",
                    "Add to Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvProducts.SelectedRows[0].DataBoundItem is not ProductForSale product)
            {
                return;
            }

            int quantity = Convert.ToInt32(numQuantity.Value);

            OrderLine? existing = order.FirstOrDefault(o => o.ProductID == product.ProductID);
            int alreadyInOrder = existing?.Quantity ?? 0;

            if (alreadyInOrder + quantity > product.StockQuantity)
            {
                MessageBox.Show(
                    "Only " + product.StockQuantity + " in stock for \"" + product.ProductName + "\"" +
                    (alreadyInOrder > 0 ? " (" + alreadyInOrder + " already in the order)." : "."),
                    "Not Enough Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (existing != null)
            {
                existing.Quantity = alreadyInOrder + quantity;
                order.ResetBindings();
            }
            else
            {
                order.Add(new OrderLine
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice,
                    Quantity = quantity
                });
            }

            numQuantity.Value = 1;
            UpdateTotals();
        }

        private void btnRemoveItem_Click(object? sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an item in the Current Order first.",
                    "Remove Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvOrder.SelectedRows[0].DataBoundItem is OrderLine line)
            {
                order.Remove(line);
                UpdateTotals();
            }
        }

        private void btnClearOrder_Click(object? sender, EventArgs e)
        {
            ClearOrder(true);
        }

        private void btnNewSale_Click(object? sender, EventArgs e)
        {
            ClearOrder(true);
        }

        private void ClearOrder(bool askFirst)
        {
            if (order.Count == 0)
                return;

            if (askFirst)
            {
                DialogResult result = MessageBox.Show(
                    "Clear the whole order?",
                    "Clear Order",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }

            order.Clear();
            UpdateTotals();
        }

        private decimal GetTotal()
        {
            decimal total = 0;

            foreach (OrderLine line in order)
            {
                total += line.Subtotal;
            }

            return total;
        }

        private void UpdateTotals()
        {
            int items = 0;

            foreach (OrderLine line in order)
            {
                items += line.Quantity;
            }

            lblItemCount.Text = "Items: " + items;
            lblTotal.Text = "₱ " + GetTotal().ToString("N2");
        }

        // ------------------------------------------------------------------
        // CHECKOUT
        // ------------------------------------------------------------------
        private void btnCheckout_Click(object? sender, EventArgs e)
        {
            if (order.Count == 0)
            {
                MessageBox.Show(
                    "The order is empty. Add at least one product.",
                    "Checkout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                decimal total = GetTotal();

                using (PaymentForm payment = new PaymentForm(total))
                {
                    if (payment.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    int saleID = cashierService.CreateSale(
                        Session.UserId,
                        order.ToList(),
                        payment.PaymentMethod,
                        payment.AmountPaid);

                    order.Clear();
                    UpdateTotals();
                    LoadProducts();

                    // Tapos na ang sale. Kung hindi mabuksan ang resibo, saved pa rin ang sale.
                    try
                    {
                        using (ReceiptForm receipt = new ReceiptForm(saleID))
                        {
                            receipt.ShowDialog(this);
                        }
                    }
                    catch (Exception receiptEx)
                    {
                        MessageBox.Show(
                            "The sale was saved (Sale #" + saleID + ") but the receipt could not be opened:\n" +
                            receiptEx.Message + "\n\nYou can open it later in My Sales.",
                            "Receipt",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Checkout Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Baka nagbago ang stock, kaya i-refresh ang listahan
                LoadProducts();
            }
        }

        // Tinatawag ng CashierNav bago lumipat ng page
        public bool CanLeave()
        {
            if (order.Count == 0)
                return true;

            DialogResult result = MessageBox.Show(
                "You still have items in the current order.\nLeave and discard them?",
                "Current Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
    }
}

