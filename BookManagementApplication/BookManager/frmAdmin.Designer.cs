namespace BookManager
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            panel1 = new Panel();
            label3 = new Label();
            picBoxLogo = new PictureBox();
            groupBox1 = new GroupBox();
            btnUserManagement = new Button();
            btnBookManagement = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(picBoxLogo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 81);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Ink Free", 48F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(602, 79);
            label3.TabIndex = 21;
            label3.Text = "Library Management";
            // 
            // picBoxLogo
            // 
            picBoxLogo.BackColor = Color.Black;
            picBoxLogo.BackgroundImageLayout = ImageLayout.None;
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(0, 0);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(80, 80);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 20;
            picBoxLogo.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUserManagement);
            groupBox1.Controls.Add(btnBookManagement);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 369);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.AutoSize = true;
            btnUserManagement.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.Black;
            btnUserManagement.Location = new Point(129, 183);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(186, 36);
            btnUserManagement.TabIndex = 7;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnBookManagement
            // 
            btnBookManagement.AutoSize = true;
            btnBookManagement.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookManagement.ForeColor = Color.Black;
            btnBookManagement.Location = new Point(195, 245);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(215, 36);
            btnBookManagement.TabIndex = 6;
            btnBookManagement.Text = "Book Management";
            btnBookManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Ink Free", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 95);
            label1.Name = "label1";
            label1.Size = new Size(239, 34);
            label1.TabIndex = 5;
            label1.Text = "Welcome Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdmin";
            Text = "Admin Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private PictureBox picBoxLogo;
        private GroupBox groupBox1;
        private Button btnUserManagement;
        private Button btnBookManagement;
        private Label label1;
    }
}