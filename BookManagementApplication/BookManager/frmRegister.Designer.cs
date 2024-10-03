namespace BookManager
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            groupBox1 = new GroupBox();
            cboxOptionalChoice = new ComboBox();
            picBoxLogo = new PictureBox();
            btnSignUp = new Button();
            label5 = new Label();
            txtNewPassword = new TextBox();
            txtNewEmail = new TextBox();
            txtNewUserName = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(cboxOptionalChoice);
            groupBox1.Controls.Add(picBoxLogo);
            groupBox1.Controls.Add(btnSignUp);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtNewEmail);
            groupBox1.Controls.Add(txtNewUserName);
            groupBox1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 387);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cboxOptionalChoice
            // 
            cboxOptionalChoice.BackColor = Color.Black;
            cboxOptionalChoice.FlatStyle = FlatStyle.Popup;
            cboxOptionalChoice.ForeColor = Color.White;
            cboxOptionalChoice.FormattingEnabled = true;
            cboxOptionalChoice.Location = new Point(6, 271);
            cboxOptionalChoice.Name = "cboxOptionalChoice";
            cboxOptionalChoice.Size = new Size(128, 28);
            cboxOptionalChoice.TabIndex = 19;
            // 
            // picBoxLogo
            // 
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(113, 26);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(90, 90);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 18;
            picBoxLogo.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Black;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Ink Free", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Transparent;
            btnSignUp.Location = new Point(221, 305);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 35);
            btnSignUp.TabIndex = 17;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Ink Free", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Size = new Size(305, 32);
            label5.TabIndex = 16;
            label5.Text = "Create your account";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.Black;
            txtNewPassword.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Location = new Point(6, 232);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Enter your password";
            txtNewPassword.Size = new Size(305, 33);
            txtNewPassword.TabIndex = 5;
            // 
            // txtNewEmail
            // 
            txtNewEmail.BackColor = Color.Black;
            txtNewEmail.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewEmail.ForeColor = Color.White;
            txtNewEmail.Location = new Point(6, 193);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.PlaceholderText = "Enter your mail";
            txtNewEmail.Size = new Size(305, 33);
            txtNewEmail.TabIndex = 4;
            // 
            // txtNewUserName
            // 
            txtNewUserName.BackColor = Color.Black;
            txtNewUserName.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUserName.ForeColor = Color.White;
            txtNewUserName.Location = new Point(6, 154);
            txtNewUserName.Name = "txtNewUserName";
            txtNewUserName.PlaceholderText = "Enter your name";
            txtNewUserName.Size = new Size(305, 33);
            txtNewUserName.TabIndex = 3;
            // 
            // frmRegister
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(339, 410);
            Controls.Add(groupBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNewUserName;
        private TextBox txtNewPassword;
        private TextBox txtNewEmail;
        private Label label5;
        private Button btnSignUp;
        private PictureBox picBoxLogo;
        private ComboBox cboxOptionalChoice;
    }
}