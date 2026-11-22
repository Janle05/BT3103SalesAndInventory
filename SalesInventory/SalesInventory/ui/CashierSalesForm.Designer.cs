namespace SalesInventory.ui
{
    partial class CashierSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierSalesForm));
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnMySales = new Button();
            btnNewSale = new Button();
            label1 = new Label();
            lblWelcome = new Label();
            lblRole = new Label();
            dtpStart = new DateTimePicker();
            label2 = new Label();
            dtpEnd = new DateTimePicker();
            label3 = new Label();
            btnSearch = new Button();
            dgvMySales = new DataGridView();
            btnViewReceipt = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            lblTotalSales = new Label();
            label6 = new Label();
            lblTotalTransactions = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMySales).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMySales);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnNewSale);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 1089);
            panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(47, 927);
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
            btnMySales.Location = new Point(47, 407);
            btnMySales.Name = "btnMySales";
            btnMySales.Size = new Size(430, 96);
            btnMySales.TabIndex = 22;
            btnMySales.Text = "My Sales";
            btnMySales.UseVisualStyleBackColor = true;
            // 
            // btnNewSale
            // 
            btnNewSale.FlatStyle = FlatStyle.Flat;
            btnNewSale.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSale.ForeColor = Color.White;
            btnNewSale.Location = new Point(47, 228);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(430, 96);
            btnNewSale.TabIndex = 12;
            btnNewSale.Text = "New Sale";
            btnNewSale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(606, 84);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 20;
            label1.Text = "POINT OF SALES";
        
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Monotype Corsiva", 15F, FontStyle.Bold | FontStyle.Italic);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(615, 34);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(204, 37);
            lblWelcome.TabIndex = 19;
            lblWelcome.Text = "Hello, Welcome!";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.MidnightBlue;
            lblRole.Location = new Point(1709, 37);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(104, 34);
            lblRole.TabIndex = 21;
            lblRole.Text = "Cashier";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(615, 228);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(259, 31);
            dtpStart.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F);
            label2.Location = new Point(615, 191);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 23;
            label2.Text = "Start Date";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(892, 228);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(259, 31);
            dtpEnd.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F);
            label3.Location = new Point(892, 191);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 25;
            label3.Text = "End Date";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1170, 216);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 43);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvMySales
            // 
            dgvMySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMySales.Location = new Point(615, 307);
            dgvMySales.Name = "dgvMySales";
            dgvMySales.RowHeadersWidth = 62;
            dgvMySales.Size = new Size(763, 543);
            dgvMySales.TabIndex = 27;
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.RoyalBlue;
            btnViewReceipt.FlatStyle = FlatStyle.Flat;
            btnViewReceipt.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewReceipt.Location = new Point(606, 894);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(233, 43);
            btnViewReceipt.TabIndex = 28;
            btnViewReceipt.Text = "VIEW RECEIPT";
            btnViewReceipt.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGoldenrodYellow;
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Location = new Point(1453, 344);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(411, 470);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(233, 45);
            label4.TabIndex = 30;
            label4.Text = "SUMMARY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGoldenrodYellow;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1470, 406);
            label5.Name = "label5";
            label5.Size = new Size(151, 32);
            label5.TabIndex = 31;
            label5.Text = "Total Sales:";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.BackColor = Color.LightGoldenrodYellow;
            lblTotalSales.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblTotalSales.Location = new Point(1569, 467);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(148, 41);
            lblTotalSales.TabIndex = 32;
            lblTotalSales.Text = "₱ 655.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGoldenrodYellow;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1471, 560);
            label6.Name = "label6";
            label6.Size = new Size(242, 32);
            label6.TabIndex = 33;
            label6.Text = "Total Transactions:";
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.BackColor = Color.LightGoldenrodYellow;
            lblTotalTransactions.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblTotalTransactions.Location = new Point(1584, 625);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(36, 41);
            lblTotalTransactions.TabIndex = 34;
            lblTotalTransactions.Text = "4";
            // 
            // CashierSalesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1918, 1094);
            Controls.Add(lblTotalTransactions);
            Controls.Add(label6);
            Controls.Add(lblTotalSales);
            Controls.Add(btnViewReceipt);
            Controls.Add(label5);
            Controls.Add(dgvMySales);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(dtpEnd);
            Controls.Add(label2);
            Controls.Add(dtpStart);
            Controls.Add(lblRole);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "CashierSalesForm";
            Text = "CashierSalesForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMySales).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private Panel panel1;
        private Button btnLogout;
        private Button btnMySales;
        private Button btnNewSale;
        private Label label1;
        private Label lblWelcome;
        private Label lblRole;
        private DateTimePicker dtpStart;
        private Label label2;
        private DateTimePicker dtpEnd;
        private Label label3;
        private Button btnSearch;
        private DataGridView dgvMySales;
        private Button btnViewReceipt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private Label label5;
        private Label lblTotalSales;
        private Label label6;
        private Label lblTotalTransactions;
    }
}