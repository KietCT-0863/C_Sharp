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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            picBoxLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            linklblRegister = new LinkLabel();
            linklblForgotPassword = new LinkLabel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Black;
            txtUserName.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(158, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = " User Name";
            txtUserName.Size = new Size(201, 33);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(158, 21);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(201, 33);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(158, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // picBoxLogo
            // 
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(6, 21);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(146, 143);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 7;
            picBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.E_PUFNHVQAQkOHo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 516);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linklblRegister);
            groupBox1.Controls.Add(linklblForgotPassword);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picBoxLogo);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(622, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 516);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // linklblRegister
            // 
            linklblRegister.AutoSize = true;
            linklblRegister.Font = new Font("Ink Free", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblRegister.LinkColor = Color.White;
            linklblRegister.Location = new Point(230, 487);
            linklblRegister.Name = "linklblRegister";
            linklblRegister.Size = new Size(129, 26);
            linklblRegister.TabIndex = 13;
            linklblRegister.TabStop = true;
            linklblRegister.Text = "Register now";
            linklblRegister.LinkClicked += linklblRegister_LinkClicked;
            // 
            // linklblForgotPassword
            // 
            linklblForgotPassword.AutoSize = true;
            linklblForgotPassword.Font = new Font("Ink Free", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblForgotPassword.LinkColor = Color.White;
            linklblForgotPassword.Location = new Point(267, 100);
            linklblForgotPassword.Name = "linklblForgotPassword";
            linklblForgotPassword.Size = new Size(92, 15);
            linklblForgotPassword.TabIndex = 12;
            linklblForgotPassword.TabStop = true;
            linklblForgotPassword.Text = "Forgot password";
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(158, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 487);
            label1.Name = "label1";
            label1.Size = new Size(218, 26);
            label1.TabIndex = 8;
            label1.Text = "Don't have an account?";
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1005, 540);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox picBoxLogo;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox checkBox1;
        private LinkLabel linklblForgotPassword;
        private LinkLabel linklblRegister;
    }
}
