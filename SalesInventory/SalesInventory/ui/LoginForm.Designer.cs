namespace SalesInventory
{
    partial class LoginFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrom));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 708);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(421, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(928, 586);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(452, 239);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(897, 469);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(161, 206);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 29);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(161, 283);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(280, 29);
            txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(188, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 5;
            label1.Text = "Login to your account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(641, 79);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 515);
            panel1.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(164, 356);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(279, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 261);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 184);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(164, 8);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(255, 132);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // LoginFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1343, 637);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Margin = new Padding(2);
            Name = "LoginFrom";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private PictureBox pictureBox4;
    }
}
