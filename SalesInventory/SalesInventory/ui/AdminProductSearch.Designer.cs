namespace SalesInventory.ui
{
    partial class AdminProductSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductSearch));
            panel1 = new Panel();
            btnLogout = new Button();
            btnTransactions = new Button();
            btnReports = new Button();
            btnPayments = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnSuppliers = new Button();
            btnDashboard = new Button();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            txtSearchProduct = new MaskedTextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            Category = new ListBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnTransactions);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 1098);
            panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 1022);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(506, 72);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(0, 727);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(506, 72);
            btnTransactions.TabIndex = 20;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 655);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(506, 72);
            btnReports.TabIndex = 19;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnPayments
            // 
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(0, 583);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(506, 72);
            btnPayments.TabIndex = 18;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnSales
            // 
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 513);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(506, 72);
            btnSales.TabIndex = 17;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 442);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(506, 72);
            btnInventory.TabIndex = 16;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 372);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(506, 72);
            btnProducts.TabIndex = 15;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 300);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(506, 72);
            btnCategories.TabIndex = 14;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 228);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(506, 72);
            btnSuppliers.TabIndex = 13;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 158);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(506, 72);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(126, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 142);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(597, 84);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 3;
            label1.Text = "Product Search";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProduct.Location = new Point(597, 285);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(719, 53);
            txtSearchProduct.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1642, 284);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(205, 53);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(597, 450);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1260, 363);
            dgvProducts.TabIndex = 22;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Location = new Point(1352, 284);
            Category.Margin = new Padding(4, 5, 4, 5);
            Category.Name = "Category";
            Category.Size = new Size(252, 54);
            Category.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 166);
            label3.Name = "label3";
            label3.Size = new Size(1265, 25);
            label3.TabIndex = 24;
            label3.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 384);
            label2.Name = "label2";
            label2.Size = new Size(1265, 25);
            label2.TabIndex = 25;
            label2.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // AdminProductSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1918, 1094);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Category);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminProductSearch";
            Text = "AdminProductSearch";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnTransactions;
        private Button btnReports;
        private Button btnPayments;
        private Button btnSales;
        private Button btnInventory;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnSuppliers;
        private Button btnDashboard;
        private PictureBox pictureBox4;
        private Label label1;
        private MaskedTextBox txtSearchProduct;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private ListBox Category;
        private Label label3;
        private Label label2;
    }
}