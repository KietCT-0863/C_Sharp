namespace BookManager
{
    partial class frmBookManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManagement));
            panel2 = new Panel();
            btnRemoveBook = new Button();
            btnUpdateBook = new Button();
            btnCreateBook = new Button();
            btnBack = new Button();
            dgvBookList = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            picBoxLogo = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnRemoveBook);
            panel2.Controls.Add(btnUpdateBook);
            panel2.Controls.Add(btnCreateBook);
            panel2.Controls.Add(btnBack);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 449);
            panel2.TabIndex = 3;
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.AutoSize = true;
            btnRemoveBook.Dock = DockStyle.Top;
            btnRemoveBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveBook.ForeColor = Color.Black;
            btnRemoveBook.Location = new Point(0, 72);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(178, 36);
            btnRemoveBook.TabIndex = 8;
            btnRemoveBook.Text = "Remove a Book";
            btnRemoveBook.UseVisualStyleBackColor = true;
            btnRemoveBook.Click += btnRemoveBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.AutoSize = true;
            btnUpdateBook.Dock = DockStyle.Top;
            btnUpdateBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBook.ForeColor = Color.Black;
            btnUpdateBook.Location = new Point(0, 36);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(178, 36);
            btnUpdateBook.TabIndex = 7;
            btnUpdateBook.Text = "Update a Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnCreateBook
            // 
            btnCreateBook.AutoSize = true;
            btnCreateBook.Dock = DockStyle.Top;
            btnCreateBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateBook.ForeColor = Color.Black;
            btnCreateBook.Location = new Point(0, 0);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(178, 36);
            btnCreateBook.TabIndex = 6;
            btnCreateBook.Text = "Create a Book";
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Dock = DockStyle.Bottom;
            btnBack.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(0, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(178, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvBookList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookList.ColumnHeadersHeight = 30;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBookList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBookList.Dock = DockStyle.Fill;
            dgvBookList.GridColor = Color.Black;
            dgvBookList.Location = new Point(178, 81);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvBookList.Size = new Size(708, 449);
            dgvBookList.TabIndex = 4;
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
            panel1.Size = new Size(886, 81);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 48F);
            label3.Location = new Point(86, 2);
            label3.Name = "label3";
            label3.Size = new Size(602, 79);
            label3.TabIndex = 22;
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
            // frmBookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 530);
            Controls.Add(dgvBookList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmBookManagement";
            Text = "Book Management";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dgvBookList;
        private Button btnBack;
        private Panel panel1;
        private PictureBox picBoxLogo;
        private Label label3;
        private Button btnRemoveBook;
        private Button btnUpdateBook;
        private Button btnCreateBook;
    }
}