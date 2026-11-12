namespace SalesInventory.ui
{
    partial class CashierSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierSales));
            panel1 = new Panel();
            button10 = new Button();
            btnPayments = new Button();
            btnSales = new Button();
            pictureBox4 = new PictureBox();
            btnDashboard = new Button();
            btnInventory = new Button();
            btnProducts = new Button();
            txtSearchProduct = new MaskedTextBox();
            btnSearch = new Button();
            label1 = new Label();
            dgvProducts = new DataGridView();
            btnClearCart = new Button();
            btnProceedToCheckout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnProducts);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 659);
            panel1.TabIndex = 3;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 613);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(354, 43);
            button10.TabIndex = 21;
            button10.Text = "Logout";
            button10.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(0, 263);
            btnPayments.Margin = new Padding(2);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(354, 43);
            btnPayments.TabIndex = 18;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 221);
            btnSales.Margin = new Padding(2);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(354, 43);
            btnSales.TabIndex = 17;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 1);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(123, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 93);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(354, 43);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 178);
            btnInventory.Margin = new Padding(2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(354, 43);
            btnInventory.TabIndex = 16;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 136);
            btnProducts.Margin = new Padding(2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(354, 43);
            btnProducts.TabIndex = 15;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProduct.Location = new Point(380, 99);
            txtSearchProduct.Margin = new Padding(2);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(484, 38);
            txtSearchProduct.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(966, 105);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 32);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Add To Cart";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(380, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 8;
            label1.Text = "Sales";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(380, 167);
            dgvProducts.Margin = new Padding(2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(882, 218);
            dgvProducts.TabIndex = 23;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.Red;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(380, 561);
            btnClearCart.Margin = new Padding(2);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(189, 54);
            btnClearCart.TabIndex = 36;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            // 
            // btnProceedToCheckout
            // 
            btnProceedToCheckout.BackColor = Color.LimeGreen;
            btnProceedToCheckout.FlatStyle = FlatStyle.Flat;
            btnProceedToCheckout.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceedToCheckout.ForeColor = Color.White;
            btnProceedToCheckout.Location = new Point(906, 561);
            btnProceedToCheckout.Margin = new Padding(2);
            btnProceedToCheckout.Name = "btnProceedToCheckout";
            btnProceedToCheckout.Size = new Size(189, 54);
            btnProceedToCheckout.TabIndex = 37;
            btnProceedToCheckout.Text = "Proceed to Checkout";
            btnProceedToCheckout.UseVisualStyleBackColor = false;
            // 
            // CashierSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 714);
            Controls.Add(btnProceedToCheckout);
            Controls.Add(btnClearCart);
            Controls.Add(dgvProducts);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(panel1);
            Name = "CashierSales";
            Text = "CashierSales";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button10;
        private Button btnPayments;
        private Button btnSales;
        private PictureBox pictureBox4;
        private Button btnDashboard;
        private Button btnInventory;
        private Button btnProducts;
        private MaskedTextBox txtSearchProduct;
        private Button btnSearch;
        private Label label1;
        private DataGridView dgvProducts;
        private Button btnClearCart;
        private Button btnProceedToCheckout;
    }
}