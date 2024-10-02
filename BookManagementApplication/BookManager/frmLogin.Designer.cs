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
            groupBox1 = new GroupBox();
            label2 = new Label();
            linklblRegister = new LinkLabel();
            linklblForgotPassword = new LinkLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Black;
            txtUserName.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(6, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = " User Name";
            txtUserName.Size = new Size(305, 33);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(6, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(305, 33);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Ink Free", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(113, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // picBoxLogo
            // 
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(113, 26);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(90, 90);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 7;
            picBoxLogo.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(linklblRegister);
            groupBox1.Controls.Add(linklblForgotPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picBoxLogo);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(622, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 387);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.Font = new Font("Ink Free", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 119);
            label2.Name = "label2";
            label2.Size = new Size(305, 32);
            label2.TabIndex = 14;
            label2.Text = "Welcome back !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linklblRegister
            // 
            linklblRegister.AutoSize = true;
            linklblRegister.Font = new Font("Ink Free", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblRegister.LinkColor = Color.White;
            linklblRegister.Location = new Point(230, 356);
            linklblRegister.Name = "linklblRegister";
            linklblRegister.Size = new Size(81, 26);
            linklblRegister.TabIndex = 13;
            linklblRegister.TabStop = true;
            linklblRegister.Text = "Sign Up";
            linklblRegister.LinkClicked += linklblRegister_LinkClicked;
            // 
            // linklblForgotPassword
            // 
            linklblForgotPassword.AutoSize = true;
            linklblForgotPassword.Font = new Font("Ink Free", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblForgotPassword.LinkColor = Color.White;
            linklblForgotPassword.Location = new Point(219, 229);
            linklblForgotPassword.Name = "linklblForgotPassword";
            linklblForgotPassword.Size = new Size(92, 15);
            linklblForgotPassword.TabIndex = 12;
            linklblForgotPassword.TabStop = true;
            linklblForgotPassword.Text = "Forgot password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 356);
            label1.Name = "label1";
            label1.Size = new Size(218, 26);
            label1.TabIndex = 8;
            label1.Text = "Don't have an account?";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.E_PUFNHVQAQkOHo;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(604, 387);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(950, 410);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox picBoxLogo;
        private GroupBox groupBox1;
        private Label label1;
        private LinkLabel linklblForgotPassword;
        private LinkLabel linklblRegister;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
