namespace SalesInventory.ui
{
    partial class PaymentForm
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
            label1 = new Label();
            label2 = new Label();
            lblTotalAmount = new Label();
            label3 = new Label();
            cmbMethod = new ComboBox();
            label4 = new Label();
            numAmountReceived = new NumericUpDown();
            label5 = new Label();
            lblChange = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmountReceived).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 116);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.Blue;
            lblTotalAmount.Location = new Point(236, 97);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(148, 45);
            lblTotalAmount.TabIndex = 2;
            lblTotalAmount.Text = "₱ 210.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 189);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 3;
            label3.Text = "Pyament Method";
            // 
            // cmbMethod
            // 
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Location = new Point(236, 187);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(121, 23);
            cmbMethod.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 253);
            label4.Name = "label4";
            label4.Size = new Size(145, 21);
            label4.TabIndex = 5;
            label4.Text = "Amount Received";
            // 
            // numAmountReceived
            // 
            numAmountReceived.DecimalPlaces = 2;
            numAmountReceived.Location = new Point(236, 251);
            numAmountReceived.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numAmountReceived.Name = "numAmountReceived";
            numAmountReceived.Size = new Size(120, 23);
            numAmountReceived.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 326);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 7;
            label5.Text = "Change";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Green;
            lblChange.Location = new Point(236, 307);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(130, 45);
            lblChange.TabIndex = 8;
            lblChange.Text = "₱ 40.00";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Green;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(45, 400);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(167, 56);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "CONFIRM PAYMENT";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(236, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 56);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(485, 587);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblChange);
            Controls.Add(label5);
            Controls.Add(numAmountReceived);
            Controls.Add(label4);
            Controls.Add(cmbMethod);
            Controls.Add(label3);
            Controls.Add(lblTotalAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)numAmountReceived).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblTotalAmount;
        private Label label3;
        private ComboBox cmbMethod;
        private Label label4;
        private NumericUpDown numAmountReceived;
        private Label label5;
        private Label lblChange;
        private Button btnConfirm;
        private Button btnCancel;
    }
}