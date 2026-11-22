using SalesInventory.businesslogic;

namespace SalesInventory.ui
{
    public partial class InventoryManagement : Form
    {
        private readonly InventoryService inventoryService;

        private int selectedProductID = 0;
        private string selectedProductName = "";
        private int selectedStock = 0;

        public InventoryManagement()
        {
            InitializeComponent();

            inventoryService = new InventoryService();

            NavHelper.Wire(this, "Inventory");
            GridHelper.Apply(dgvInventory);

            
            btnAdd.Text = "STOCK IN";
            btnUpdate.Text = "SET COUNT";
            btnDelete.Text = "STOCK OUT";

            btnSearch.Click += btnSearch_Click;
            btnAdd.Click += btnStockIn_Click;
            btnUpdate.Click += btnSetCount_Click;
            btnDelete.Click += btnStockOut_Click;

            dgvInventory.CellClick += dgvInventory_CellClick;
            dgvInventory.DataBindingComplete += dgvInventory_DataBindingComplete;

            LoadInventory();
        }

        private void LoadInventory()
        {
            try
            {
                selectedProductID = 0;
                selectedProductName = "";
                selectedStock = 0;

                dgvInventory.DataSource = inventoryService.GetInventory(txtSearch.Text);
                dgvInventory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading inventory:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvInventory_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                string status = row.Cells["StockStatus"].Value?.ToString() ?? "";

                if (status == "Out of Stock")
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                }
                else if (status == "Low Stock")
                {
                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
        }

        private void dgvInventory_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

            selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
            selectedProductName = row.Cells["ProductName"].Value?.ToString() ?? "";
            selectedStock = Convert.ToInt32(row.Cells["StockQuantity"].Value);
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadInventory();
        }

        private bool HasSelection()
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show(
                    "Please select a product from the table first.",
                    "Inventory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        
        private void btnStockIn_Click(object? sender, EventArgs e)
        {
            if (!HasSelection())
                return;

            var input = InputDialogs.AskQuantity(
                "Stock In",
                selectedProductName + "\nCurrent stock: " + selectedStock,
                1,
                1000000,
                1,
                "Delivery from supplier");

            if (!input.Ok)
                return;

            try
            {
                inventoryService.StockIn(selectedProductID, input.Quantity, input.Reason, Session.UserId);

                MessageBox.Show(
                    "Stock added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Stock In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void btnStockOut_Click(object? sender, EventArgs e)
        {
            if (!HasSelection())
                return;

            if (selectedStock <= 0)
            {
                MessageBox.Show(
                    "This product has no stock to remove.",
                    "Stock Out",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var input = InputDialogs.AskQuantity(
                "Stock Out",
                selectedProductName + "\nCurrent stock: " + selectedStock,
                1,
                selectedStock,
                1,
                "Damaged / expired");

            if (!input.Ok)
                return;

            try
            {
                inventoryService.StockOut(selectedProductID, input.Quantity, input.Reason, Session.UserId);

                MessageBox.Show(
                    "Stock removed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Stock Out",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
        private void btnSetCount_Click(object? sender, EventArgs e)
        {
            if (!HasSelection())
                return;

            var input = InputDialogs.AskQuantity(
                "Set Stock Count",
                selectedProductName + "\nCurrent stock: " + selectedStock + "\nType the correct count.",
                0,
                1000000,
                selectedStock,
                "Physical count");

            if (!input.Ok)
                return;

            try
            {
                inventoryService.SetCount(selectedProductID, input.Quantity, input.Reason, Session.UserId);

                MessageBox.Show(
                    "Stock count updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Update Count",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnDashboard_Click(object sender, EventArgs e) { }
    }
}
