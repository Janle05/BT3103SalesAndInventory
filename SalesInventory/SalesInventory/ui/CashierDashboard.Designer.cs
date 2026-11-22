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
            btnLogout = new Button();
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
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            label5 = new Label();
            numQuantity = new NumericUpDown();
            btnAddToOrder = new Button();
            dgvOrder = new DataGridView();
            label6 = new Label();
            btnRemoveItem = new Button();
            btnClearOrder = new Button();
            pnlTotal = new Panel();
            lblTotal = new Label();
            label7 = new Label();
            lblItemCount = new Label();
            btnCheckout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
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
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 1778);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(26, 973);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(430, 96);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMySales
            // 
            btnMySales.FlatStyle = FlatStyle.Flat;
            btnMySales.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMySales.ForeColor = Color.White;
            btnMySales.Location = new Point(26, 404);
            btnMySales.Name = "btnMySales";
            btnMySales.Size = new Size(430, 96);
            btnMySales.TabIndex = 22;
            btnMySales.Text = "My Sales";
            btnMySales.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(112, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(241, 155);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnNewSale
            // 
            btnNewSale.FlatStyle = FlatStyle.Flat;
            btnNewSale.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSale.ForeColor = Color.White;
            btnNewSale.Location = new Point(26, 242);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(430, 96);
            btnNewSale.TabIndex = 12;
            btnNewSale.Text = "New Sale";
            btnNewSale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(559, 35);
            label4.Name = "label4";
            label4.Size = new Size(204, 37);
            label4.TabIndex = 9;
            label4.Text = "Hello, Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(2343, 38);
            label2.Name = "label2";
            label2.Size = new Size(104, 34);
            label2.TabIndex = 6;
            label2.Text = "Cashier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(550, 85);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 18;
            label1.Text = "POINT OF SALES";
         
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 128);
            label3.Name = "label3";
            label3.Size = new Size(1279, 25);
            label3.TabIndex = 30;
            label3.Text = "_____________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2464, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(568, 210);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(234, 34);
            txtSearch.TabIndex = 32;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(831, 211);
            cmbCategory.Margin = new Padding(4, 5, 4, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(289, 33);
            cmbCategory.TabIndex = 33;
            cmbCategory.Text = "All Categories";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1148, 210);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(167, 48);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(568, 272);
            dgvProducts.Margin = new Padding(4, 5, 4, 5);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(747, 630);
            dgvProducts.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(559, 934);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 27);
            label5.TabIndex = 36;
            label5.Text = "QUANTITY:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(722, 930);
            numQuantity.Margin = new Padding(4, 5, 4, 5);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(132, 31);
            numQuantity.TabIndex = 37;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.BackColor = Color.Blue;
            btnAddToOrder.FlatStyle = FlatStyle.Flat;
            btnAddToOrder.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToOrder.ForeColor = Color.White;
            btnAddToOrder.Location = new Point(880, 921);
            btnAddToOrder.Margin = new Padding(4, 5, 4, 5);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(183, 48);
            btnAddToOrder.TabIndex = 38;
            btnAddToOrder.Text = "ADD TO ORDER";
            btnAddToOrder.UseVisualStyleBackColor = false;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(1383, 272);
            dgvOrder.Margin = new Padding(4, 5, 4, 5);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.Size = new Size(472, 423);
            dgvOrder.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1383, 211);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 35);
            label6.TabIndex = 40;
            label6.Text = "Current Order";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.Orange;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(1383, 724);
            btnRemoveItem.Margin = new Padding(4, 5, 4, 5);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(196, 66);
            btnRemoveItem.TabIndex = 41;
            btnRemoveItem.Text = "REMOVE";
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnClearOrder
            // 
            btnClearOrder.BackColor = Color.Gray;
            btnClearOrder.FlatStyle = FlatStyle.Flat;
            btnClearOrder.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnClearOrder.ForeColor = Color.White;
            btnClearOrder.Location = new Point(1659, 724);
            btnClearOrder.Margin = new Padding(4, 5, 4, 5);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(196, 66);
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
            pnlTotal.Location = new Point(1383, 803);
            pnlTotal.Margin = new Padding(4, 5, 4, 5);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(472, 157);
            pnlTotal.TabIndex = 43;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(166, 57);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(243, 71);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "₱ 210.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(23, 82);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 40);
            label7.TabIndex = 1;
            label7.Text = "TOTAL:";
            // 
            // lblItemCount
            // 
            lblItemCount.AutoSize = true;
            lblItemCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemCount.Location = new Point(23, 12);
            lblItemCount.Margin = new Padding(4, 0, 4, 0);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(93, 31);
            lblItemCount.TabIndex = 0;
            lblItemCount.Text = "Items: 6";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Green;
            btnCheckout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(1383, 975);
            btnCheckout.Margin = new Padding(4, 5, 4, 5);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(472, 91);
            btnCheckout.TabIndex = 44;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1924, 1094);
            Controls.Add(btnCheckout);
            Controls.Add(pnlTotal);
            Controls.Add(btnClearOrder);
            Controls.Add(btnRemoveItem);
            Controls.Add(label6);
            Controls.Add(dgvOrder);
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
            Name = "CashierDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierDashboard";
          
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
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
        private DataGridView dgvOrder;
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