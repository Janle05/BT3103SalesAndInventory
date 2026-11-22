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
            panel1 = new Panel();
            btnLogout = new Button();
            btnMySales = new Button();
            pictureBox4 = new PictureBox();
            btnNewSale = new Button();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnSearch = new Button();
            dgvMySales = new DataGridView();
            btnViewReceipt = new Button();
            pnlSummary = new Panel();
            label7 = new Label();
            label6 = new Label();
            lblTotalSales = new Label();
            label8 = new Label();
            lblTotalTransactions = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMySales).BeginInit();
            pnlSummary.SuspendLayout();
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
            panel1.Size = new Size(351, 1067);
            panel1.TabIndex = 2;
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
            label4.Size = new Size(129, 24);
            label4.TabIndex = 10;
            label4.Text = "Hello, Cashier!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(385, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 19;
            label1.Text = "My Sales";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1725, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
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
            label2.TabIndex = 32;
            label2.Text = "Cashier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(442, 121);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 34;
            label3.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(748, 121);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 35;
            label5.Text = "End Date";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(442, 144);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 36;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(748, 144);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 37;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1019, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 32);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvMySales
            // 
            dgvMySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMySales.Location = new Point(385, 190);
            dgvMySales.Name = "dgvMySales";
            dgvMySales.Size = new Size(753, 602);
            dgvMySales.TabIndex = 39;
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.Blue;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReceipt.ForeColor = Color.White;
            btnViewReceipt.Location = new Point(391, 835);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(151, 50);
            btnViewReceipt.TabIndex = 40;
            btnViewReceipt.Text = "VIEW RECEIPT";
            btnViewReceipt.UseVisualStyleBackColor = false;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.CadetBlue;
            pnlSummary.Controls.Add(lblTotalTransactions);
            pnlSummary.Controls.Add(label8);
            pnlSummary.Controls.Add(lblTotalSales);
            pnlSummary.Controls.Add(label7);
            pnlSummary.Controls.Add(label6);
            pnlSummary.Location = new Point(1192, 190);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(409, 366);
            pnlSummary.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 114);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 1;
            label7.Text = "Total Sales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 33);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 0;
            label6.Text = "Summary";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.White;
            lblTotalSales.Location = new Point(38, 134);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(113, 32);
            lblTotalSales.TabIndex = 2;
            lblTotalSales.Text = "₱ 655.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 224);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 3;
            label8.Text = "Total Transactions";
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransactions.ForeColor = Color.White;
            lblTotalTransactions.Location = new Point(38, 244);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(28, 32);
            lblTotalTransactions.TabIndex = 4;
            lblTotalTransactions.Text = "4";
            // 
            // CashierSalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1924, 1061);
            Controls.Add(pnlSummary);
            Controls.Add(btnViewReceipt);
            Controls.Add(dgvMySales);
            Controls.Add(btnSearch);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "CashierSalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierSalesForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMySales).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnMySales;
        private PictureBox pictureBox4;
        private Button btnNewSale;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnSearch;
        private DataGridView dgvMySales;
        private Button btnViewReceipt;
        private Panel pnlSummary;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label lblTotalSales;
        private Label lblTotalTransactions;
    }
}