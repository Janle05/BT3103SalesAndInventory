namespace SalesInventory.ui
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            btnLogout = new Button();
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
            lblRole = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lblWelcome = new Label();
            dgvLowStock = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 1100);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 1026);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(506, 72);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 673);
            btnReports.Margin = new Padding(2);
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
            btnPayments.Location = new Point(0, 529);
            btnPayments.Margin = new Padding(2);
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
            btnSales.Location = new Point(0, 601);
            btnSales.Margin = new Padding(2);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(506, 72);
            btnSales.TabIndex = 17;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 457);
            btnInventory.Margin = new Padding(2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(506, 72);
            btnInventory.TabIndex = 16;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(-1, 385);
            btnProducts.Margin = new Padding(2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(506, 72);
            btnProducts.TabIndex = 15;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(-1, 313);
            btnCategories.Margin = new Padding(2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(506, 72);
            btnCategories.TabIndex = 14;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(-1, 244);
            btnSuppliers.Margin = new Padding(2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(506, 72);
            btnSuppliers.TabIndex = 13;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(-1, 172);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(506, 72);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(125, 13);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(219, 123);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.LightBlue;
            label1.Location = new Point(581, 154);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Times New Roman", 15F);
            lblRole.ForeColor = Color.MidnightBlue;
            lblRole.Location = new Point(1584, 57);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(96, 34);
            lblRole.TabIndex = 2;
            lblRole.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1454, 27);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 112);
            label3.Name = "label3";
            label3.Size = new Size(1265, 25);
            label3.TabIndex = 4;
            label3.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold | FontStyle.Italic);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(581, 57);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(204, 37);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Hello, Welcome!";
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Location = new Point(581, 386);
            dgvLowStock.Margin = new Padding(2);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersWidth = 62;
            dgvLowStock.Size = new Size(1307, 495);
            dgvLowStock.TabIndex = 33;
            dgvLowStock.CellContentClick += dgvLowStock_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 215);
            label2.Name = "label2";
            label2.Size = new Size(1265, 25);
            label2.TabIndex = 34;
            label2.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(581, 291);
            label4.Name = "label4";
            label4.Size = new Size(561, 47);
            label4.TabIndex = 35;
            label4.Text = "Low Stock and Out of Stock Items";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 192);
            flowLayoutPanel1.ForeColor = Color.FromArgb(0, 0, 192);
            flowLayoutPanel1.Location = new Point(581, 128);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1257, 105);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1918, 1094);
            Controls.Add(label4);
            Controls.Add(dgvLowStock);
            Controls.Add(lblWelcome);
            Controls.Add(lblRole);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private Button btnSuppliers;
        private Button btnDashboard;
        private Button btnCategories;
        private Button btnSales;
        private Button btnInventory;
        private Button btnProducts;
        private Button btnLogout;
        private Button btnReports;
        private Button btnPayments;
        private Label label1;
        private Label lblRole;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblWelcome;
        private DataGridView dgvLowStock;
        private Label label2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}