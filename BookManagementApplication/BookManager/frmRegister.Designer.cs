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
            panel1 = new Panel();
            cboxOptionalChoice = new ComboBox();
            picBoxLogo = new PictureBox();
            btnSignUp = new Button();
            label5 = new Label();
            txtNewPassword = new TextBox();
            txtNewEmail = new TextBox();
            txtNewUserName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboxOptionalChoice);
            panel1.Controls.Add(picBoxLogo);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(txtNewEmail);
            panel1.Controls.Add(txtNewUserName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 410);
            panel1.TabIndex = 0;
            // 
            // cboxOptionalChoice
            // 
            cboxOptionalChoice.BackColor = Color.White;
            cboxOptionalChoice.FlatStyle = FlatStyle.Popup;
            cboxOptionalChoice.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxOptionalChoice.ForeColor = Color.Black;
            cboxOptionalChoice.FormattingEnabled = true;
            cboxOptionalChoice.Location = new Point(12, 281);
            cboxOptionalChoice.Name = "cboxOptionalChoice";
            cboxOptionalChoice.Size = new Size(169, 34);
            cboxOptionalChoice.TabIndex = 26;
            // 
            // picBoxLogo
            // 
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(124, 36);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(90, 90);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 25;
            picBoxLogo.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Ink Free", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(237, 321);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 35);
            btnSignUp.TabIndex = 24;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Ink Free", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(315, 32);
            label5.TabIndex = 23;
            label5.Text = "Create your account";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(12, 242);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Enter your password";
            txtNewPassword.Size = new Size(315, 33);
            txtNewPassword.TabIndex = 22;
            // 
            // txtNewEmail
            // 
            txtNewEmail.BackColor = Color.White;
            txtNewEmail.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewEmail.ForeColor = Color.Black;
            txtNewEmail.Location = new Point(12, 203);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.PlaceholderText = "Enter your mail";
            txtNewEmail.Size = new Size(315, 33);
            txtNewEmail.TabIndex = 21;
            // 
            // txtNewUserName
            // 
            txtNewUserName.BackColor = Color.White;
            txtNewUserName.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUserName.ForeColor = Color.Black;
            txtNewUserName.Location = new Point(12, 164);
            txtNewUserName.Name = "txtNewUserName";
            txtNewUserName.PlaceholderText = "Enter your name";
            txtNewUserName.Size = new Size(315, 33);
            txtNewUserName.TabIndex = 20;
            // 
            // frmRegister
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(339, 410);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboxOptionalChoice;
        private PictureBox picBoxLogo;
        private Button btnSignUp;
        private Label label5;
        private TextBox txtNewPassword;
        private TextBox txtNewEmail;
        private TextBox txtNewUserName;
    }
}