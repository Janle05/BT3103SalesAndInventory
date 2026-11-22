namespace SalesInventory.ui
{
    partial class CashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            panel1 = new Panel();
            btnMySales = new Button();
            pictureBox4 = new PictureBox();
            btnNewSale = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            btnLogout = new Button();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            label5 = new Label();
            numQuantity = new NumericUpDown();
            btnAddToOrder = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            btnRemoveItem = new Button();
            btnClearOrder = new Button();
            pnlTotal = new Panel();
            lblItemCount = new Label();
            label7 = new Label();
            lblTotal = new Label();
            btnCheckout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMySales);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnNewSale);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 1067);
            panel1.TabIndex = 1;
            // 
            // btnMySales
            // 
            btnMySales.FlatStyle = FlatStyle.Flat;
            btnMySales.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMySales.ForeColor = Color.White;
            btnMySales.Location = new Point(12, 354);
            btnMySales.Margin = new Padding(2);
            btnMySales.Name = "btnMySales";
            btnMySales.Size = new Size(319, 79);
            btnMySales.TabIndex = 22;
            btnMySales.Text = "My Sales";
            btnMySales.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(47, 10);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(249, 135);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnNewSale
            // 
            btnNewSale.FlatStyle = FlatStyle.Flat;
            btnNewSale.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSale.ForeColor = Color.White;
            btnNewSale.Location = new Point(12, 222);
            btnNewSale.Margin = new Padding(2);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(319, 79);
            btnNewSale.TabIndex = 12;
            btnNewSale.Text = "New Sale";
            btnNewSale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(391, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 24);
            label4.TabIndex = 9;
            label4.Text = "Hello, Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(1640, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 6;
            label2.Text = "Cashier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(385, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 18;
            label1.Text = "DASHBOARD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(912, 15);
            label3.TabIndex = 30;
            label3.Text = "_____________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1725, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(391, 124);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(333, 22);
            txtSearch.TabIndex = 32;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(783, 123);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(328, 23);
            cmbCategory.TabIndex = 33;
            cmbCategory.Text = "All Categories";
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 956);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(319, 79);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1152, 107);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 39);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(385, 183);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(884, 631);
            dgvProducts.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(391, 835);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 36;
            label5.Text = "QUANTITY:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(492, 833);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 37;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.BackColor = Color.Blue;
            btnAddToOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToOrder.ForeColor = Color.White;
            btnAddToOrder.Location = new Point(635, 833);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(128, 45);
            btnAddToOrder.TabIndex = 38;
            btnAddToOrder.Text = "ADD TO ORDER";
            btnAddToOrder.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1315, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(504, 378);
            dataGridView1.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1315, 155);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 40;
            label6.Text = "Current Order";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.Orange;
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(1315, 590);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(250, 77);
            btnRemoveItem.TabIndex = 41;
            btnRemoveItem.Text = "REMOVE";
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnClearOrder
            // 
            btnClearOrder.BackColor = Color.Gray;
            btnClearOrder.ForeColor = Color.White;
            btnClearOrder.Location = new Point(1569, 590);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(250, 77);
            btnClearOrder.TabIndex = 42;
            btnClearOrder.Text = "CLEAR";
            btnClearOrder.UseVisualStyleBackColor = false;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(label7);
            pnlTotal.Controls.Add(lblItemCount);
            pnlTotal.Location = new Point(1315, 692);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(504, 122);
            pnlTotal.TabIndex = 43;
            // 
            // lblItemCount
            // 
            lblItemCount.AutoSize = true;
            lblItemCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemCount.Location = new Point(16, 14);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(60, 20);
            lblItemCount.TabIndex = 0;
            lblItemCount.Text = "Items: 6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(16, 65);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 1;
            label7.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(325, 47);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(161, 47);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "₱ 210.00";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Green;
            btnCheckout.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(1315, 835);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(504, 101);
            btnCheckout.TabIndex = 44;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1924, 1061);
            Controls.Add(btnCheckout);
            Controls.Add(pnlTotal);
            Controls.Add(btnClearOrder);
            Controls.Add(btnRemoveItem);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddToOrder);
            Controls.Add(numQuantity);
            Controls.Add(label5);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearch);
            Controls.Add(cmbCategory);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "CashierDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierDashboard";
            Load += CashierDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button10;
        private Button btnPayments;
        private Button btnSales;
        private Button btnInventory;
        private Button btnProducts;
        private Button btnNewSale;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Button btnMySales;
        private ComboBox cmbCategory;
        private Button btnLogout;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private Label label5;
        private NumericUpDown numQuantity;
        private Button btnAddToOrder;
        private DataGridView dataGridView1;
        private Label label6;
        private Button btnRemoveItem;
        private Button btnClearOrder;
        private Panel pnlTotal;
        private Label label7;
        private Label lblItemCount;
        private Label lblTotal;
        private Button btnCheckout;
    }
}