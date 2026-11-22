namespace SalesInventory.ui
{
    partial class ReceiptForm
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
            txtReceipt = new TextBox();
            btnPrint = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtReceipt
            // 
            txtReceipt.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceipt.Location = new Point(17, 20);
            txtReceipt.Margin = new Padding(4, 5, 4, 5);
            txtReceipt.Multiline = true;
            txtReceipt.Name = "txtReceipt";
            txtReceipt.ReadOnly = true;
            txtReceipt.ScrollBars = ScrollBars.Vertical;
            txtReceipt.Size = new Size(564, 751);
            txtReceipt.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Blue;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Times New Roman", 10F);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(17, 807);
            btnPrint.Margin = new Padding(4, 5, 4, 5);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(224, 77);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Times New Roman", 10F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(359, 807);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(224, 77);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(600, 1000);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(txtReceipt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReceiptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReceipt;
        private Button btnPrint;
        private Button btnClose;
    }
}