namespace BookManager
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            picBoxLogo = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            linklblRegister = new LinkLabel();
            txtPassword = new TextBox();
            linklblForgotPassword = new LinkLabel();
            btnLogin = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // picBoxLogo
            // 
            picBoxLogo.BackColor = Color.Black;
            picBoxLogo.BackgroundImageLayout = ImageLayout.None;
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(11, 11);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(80, 80);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 18;
            picBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(picBoxLogo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 105);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 48F);
            label3.Location = new Point(97, 12);
            label3.Name = "label3";
            label3.Size = new Size(534, 79);
            label3.TabIndex = 19;
            label3.Text = "Book Management";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linklblRegister);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(linklblForgotPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUserName);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(630, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 404);
            panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.MythLogo;
            pictureBox1.Location = new Point(110, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Ink Free", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 117);
            label2.Name = "label2";
            label2.Size = new Size(281, 32);
            label2.TabIndex = 41;
            label2.Text = "Welcome back !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linklblRegister
            // 
            linklblRegister.AutoSize = true;
            linklblRegister.Font = new Font("Ink Free", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblRegister.LinkColor = Color.White;
            linklblRegister.Location = new Point(215, 354);
            linklblRegister.Name = "linklblRegister";
            linklblRegister.Size = new Size(81, 26);
            linklblRegister.TabIndex = 40;
            linklblRegister.TabStop = true;
            linklblRegister.Text = "Sign Up";
            linklblRegister.LinkClicked += linklblRegister_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(15, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(281, 33);
            txtPassword.TabIndex = 36;
            // 
            // linklblForgotPassword
            // 
            linklblForgotPassword.AutoSize = true;
            linklblForgotPassword.Font = new Font("Ink Free", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblForgotPassword.LinkColor = Color.White;
            linklblForgotPassword.Location = new Point(204, 227);
            linklblForgotPassword.Name = "linklblForgotPassword";
            linklblForgotPassword.Size = new Size(92, 15);
            linklblForgotPassword.TabIndex = 39;
            linklblForgotPassword.TabStop = true;
            linklblForgotPassword.Text = "Forgot password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(15, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(281, 35);
            btnLogin.TabIndex = 37;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 356);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 38;
            label1.Text = "Don't have an account?";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(15, 152);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = " User Name";
            txtUserName.Size = new Size(281, 33);
            txtUserName.TabIndex = 35;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.E_PUFNHVQAQkOHo;
            pictureBox2.Location = new Point(0, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(630, 404);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(938, 509);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picBoxLogo;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel linklblRegister;
        private TextBox txtPassword;
        private LinkLabel linklblForgotPassword;
        private Button btnLogin;
        private Label label1;
        private TextBox txtUserName;
        private PictureBox pictureBox2;
    }
}
