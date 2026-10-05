namespace SalesInventory.ui
{
    partial class AdminProductMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductMaintenanceForm));
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
            button11 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            textBox2 = new TextBox();
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
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
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 1099);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 1021);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(505, 71);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(0, 726);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(505, 71);
            btnTransactions.TabIndex = 20;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 655);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(505, 71);
            btnReports.TabIndex = 19;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(0, 584);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(505, 71);
            btnPayments.TabIndex = 18;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 513);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(505, 71);
            btnSales.TabIndex = 17;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 442);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(505, 71);
            btnInventory.TabIndex = 16;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 371);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(505, 71);
            btnProducts.TabIndex = 15;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 300);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(505, 71);
            btnCategories.TabIndex = 14;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 229);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(505, 71);
            btnSuppliers.TabIndex = 13;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 158);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(505, 71);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(125, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 141);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(560, 31);
            label1.Name = "label1";
            label1.Size = new Size(384, 45);
            label1.TabIndex = 2;
            label1.Text = "Product Maintenance";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProduct.Location = new Point(568, 159);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(689, 53);
            txtSearchProduct.TabIndex = 3;
            // 
            // button11
            // 
            button11.BackColor = Color.DodgerBlue;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(1279, 159);
            button11.Name = "button11";
            button11.Size = new Size(147, 53);
            button11.TabIndex = 4;
            button11.Text = "SEARCH";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(560, 242);
            label2.Name = "label2";
            label2.Size = new Size(187, 34);
            label2.TabIndex = 5;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(875, 242);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1201, 242);
            label4.Name = "label4";
            label4.Size = new Size(114, 34);
            label4.TabIndex = 7;
            label4.Text = "Supplier";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1520, 242);
            label5.Name = "label5";
            label5.Size = new Size(87, 34);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(568, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 31);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(883, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 33);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1528, 279);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 33);
            comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1209, 279);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(300, 33);
            comboBox3.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(568, 357);
            label6.Name = "label6";
            label6.Size = new Size(135, 34);
            label6.TabIndex = 13;
            label6.Text = "Unit Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(883, 357);
            label7.Name = "label7";
            label7.Size = new Size(156, 34);
            label7.TabIndex = 14;
            label7.Text = "Initial Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(1209, 357);
            label8.Name = "label8";
            label8.Size = new Size(197, 34);
            label8.TabIndex = 15;
            label8.Text = "Recorder Level";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1528, 357);
            label9.Name = "label9";
            label9.Size = new Size(147, 34);
            label9.TabIndex = 16;
            label9.Text = "Product ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(568, 394);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(300, 31);
            numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(883, 394);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(300, 31);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(1209, 394);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(300, 31);
            numericUpDown3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1528, 394);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 31);
            textBox2.TabIndex = 20;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(568, 665);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1260, 363);
            dgvProducts.TabIndex = 21;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(568, 514);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 90);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(892, 514);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(270, 90);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1227, 514);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 90);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1558, 514);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(270, 90);
            btnClear.TabIndex = 25;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(560, 76);
            label10.Name = "label10";
            label10.Size = new Size(1265, 25);
            label10.TabIndex = 26;
            label10.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // AdminProductMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1918, 1094);
            Controls.Add(label10);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button11);
            Controls.Add(txtSearchProduct);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "AdminProductMaintenanceForm";
            Text = "AdminProductMaintenanceForm";
            Load += AdminProductMaintenanceForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
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
        private Button button11;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private TextBox textBox2;
        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label label10;
    }
}