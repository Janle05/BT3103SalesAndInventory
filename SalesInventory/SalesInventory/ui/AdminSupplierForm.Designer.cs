namespace SalesInventory.ui
{
    partial class AdminSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSupplierForm));
            panel1 = new Panel();
            btnLogout = new Button();
            btnTransactions = new Button();
            btnReports = new Button();
            btnPaymenst = new Button();
            btnSales = new Button();
            btnInventory = new Button();
            button4 = new Button();
            btnCategories = new Button();
            btnSuppliers = new Button();
            btnDashboard = new Button();
            pictureBox4 = new PictureBox();
            btnSearch = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtContactPerson = new TextBox();
            txtSupplierName = new TextBox();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dgvSuppliers = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label10 = new Label();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnTransactions);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnPaymenst);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 659);
            panel1.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 613);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(354, 43);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(0, 416);
            btnTransactions.Margin = new Padding(2);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(354, 43);
            btnTransactions.TabIndex = 20;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += button9_Click;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 373);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(354, 43);
            btnReports.TabIndex = 19;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnPaymenst
            // 
            btnPaymenst.FlatStyle = FlatStyle.Flat;
            btnPaymenst.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnPaymenst.ForeColor = Color.White;
            btnPaymenst.Location = new Point(0, 331);
            btnPaymenst.Margin = new Padding(2);
            btnPaymenst.Name = "btnPaymenst";
            btnPaymenst.Size = new Size(354, 43);
            btnPaymenst.TabIndex = 18;
            btnPaymenst.Text = "Payments";
            btnPaymenst.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 288);
            btnSales.Margin = new Padding(2);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(354, 43);
            btnSales.TabIndex = 17;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 245);
            btnInventory.Margin = new Padding(2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(354, 43);
            btnInventory.TabIndex = 16;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 203);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(354, 43);
            button4.TabIndex = 15;
            button4.Text = "Products";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnCategories
            // 
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 160);
            btnCategories.Margin = new Padding(2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(354, 43);
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
            btnSuppliers.Location = new Point(0, 118);
            btnSuppliers.Margin = new Padding(2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(354, 43);
            btnSuppliers.TabIndex = 13;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 75);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(354, 43);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(92, 0);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(174, 77);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(895, 72);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 32);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(417, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 31);
            label1.TabIndex = 28;
            label1.Text = "Supplier Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1084, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 37;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(759, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 35;
            label3.Text = "Contact Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(408, 133);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 22);
            label2.TabIndex = 34;
            label2.Text = "Supplier Name";
            // 
            // txtContactPerson
            // 
            txtContactPerson.Font = new Font("Times New Roman", 10F);
            txtContactPerson.Location = new Point(757, 150);
            txtContactPerson.Margin = new Padding(2);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(211, 23);
            txtContactPerson.TabIndex = 33;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Times New Roman", 10F);
            txtSupplierName.Location = new Point(408, 155);
            txtSupplierName.Margin = new Padding(2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(211, 23);
            txtSupplierName.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1084, 194);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 43;
            label5.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Times New Roman", 9F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(1084, 216);
            cmbStatus.Margin = new Padding(2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(211, 23);
            cmbStatus.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(759, 194);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 22);
            label6.TabIndex = 41;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(408, 195);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 22);
            label7.TabIndex = 40;
            label7.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 10F);
            txtAddress.Location = new Point(757, 217);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(211, 23);
            txtAddress.TabIndex = 39;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 10F);
            txtEmail.Location = new Point(408, 217);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 38;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Times New Roman", 9F);
            txtPhone.Location = new Point(1084, 155);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(211, 21);
            txtPhone.TabIndex = 44;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeight = 34;
            dgvSuppliers.Location = new Point(417, 353);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 62;
            dgvSuppliers.Size = new Size(1260, 363);
            dgvSuppliers.TabIndex = 49;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1110, 271);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(189, 54);
            btnClear.TabIndex = 48;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(877, 271);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 54);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(648, 271);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 54);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(417, 271);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 54);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(408, 43);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(902, 15);
            label10.TabIndex = 50;
            label10.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Tempus Sans ITC", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(408, 76);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(484, 34);
            txtSearch.TabIndex = 29;
            // 
            // AdminSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1918, 1061);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(cmbStatus);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtContactPerson);
            Controls.Add(txtSupplierName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label10);
            Margin = new Padding(2);
            Name = "AdminSupplierForm";
            Text = "AdminSupplierForm";
            Load += AdminSupplierForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnTransactions;
        private Button btnReports;
        private Button btnPaymenst;
        private Button btnSales;
        private Button btnInventory;
        private Button button4;
        private Button btnCategories;
        private Button btnSuppliers;
        private Button btnDashboard;
        private PictureBox pictureBox4;
        private Button btnSearch;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtContactPerson;
        private TextBox txtSupplierName;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label6;
        private Label label7;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DataGridView dgvSuppliers;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label10;
        private TextBox txtSearch;
    }
}