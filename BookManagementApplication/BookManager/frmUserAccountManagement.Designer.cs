namespace BookManager
{
    partial class frmUserAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccountManagement));
            btnCreateAccount = new Button();
            btnUpdateAccount = new Button();
            btnRemoveAccount = new Button();
            dgvUserAccount = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUserAccount).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.AutoSize = true;
            btnCreateAccount.Location = new Point(24, 102);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(99, 25);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.AutoSize = true;
            btnUpdateAccount.Location = new Point(24, 192);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(103, 25);
            btnUpdateAccount.TabIndex = 1;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnRemoveAccount
            // 
            btnRemoveAccount.AutoSize = true;
            btnRemoveAccount.Location = new Point(76, 318);
            btnRemoveAccount.Name = "btnRemoveAccount";
            btnRemoveAccount.Size = new Size(108, 25);
            btnRemoveAccount.TabIndex = 2;
            btnRemoveAccount.Text = "Remove Account";
            btnRemoveAccount.UseVisualStyleBackColor = true;
            btnRemoveAccount.Click += btnRemoveAccount_Click;
            // 
            // dgvUserAccount
            // 
            dgvUserAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserAccount.Location = new Point(394, 133);
            dgvUserAccount.Name = "dgvUserAccount";
            dgvUserAccount.Size = new Size(240, 150);
            dgvUserAccount.TabIndex = 3;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUserAccount);
            Controls.Add(btnRemoveAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnCreateAccount);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUserManagement";
            Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)dgvUserAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateAccount;
        private Button btnUpdateAccount;
        private Button btnRemoveAccount;
        private DataGridView dgvUserAccount;
    }
}