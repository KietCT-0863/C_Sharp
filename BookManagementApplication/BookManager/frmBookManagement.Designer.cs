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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManagement));
            panel1 = new Panel();
            lblLibraryManagement = new Label();
            picBoxLogo = new PictureBox();
            panel3 = new Panel();
            dgvBookList = new DataGridView();
            panel2 = new Panel();
            btnRemoveBook = new Button();
            btnUpdateBook = new Button();
            btnCreateBook = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            btnSearchBook = new Button();
            lblBookDescription = new Label();
            txtBookDescriptionSearch = new TextBox();
            txtBookNameSearch = new TextBox();
            lblBookName = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblLibraryManagement);
            panel1.Controls.Add(picBoxLogo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 81);
            panel1.TabIndex = 4;
            // 
            // lblLibraryManagement
            // 
            lblLibraryManagement.AutoSize = true;
            lblLibraryManagement.Font = new Font("Ink Free", 48F);
            lblLibraryManagement.Location = new Point(86, 2);
            lblLibraryManagement.Name = "lblLibraryManagement";
            lblLibraryManagement.Size = new Size(602, 79);
            lblLibraryManagement.TabIndex = 0;
            lblLibraryManagement.Text = "Library Management";
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
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(1263, 0);
            panel3.TabIndex = 9;
            // 
            // dgvBookList
            // 
            dgvBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvBookList.Location = new Point(178, 197);
            dgvBookList.Name = "dgvBookList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvBookList.Size = new Size(1085, 446);
            dgvBookList.TabIndex = 2;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
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
            panel2.Location = new Point(0, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 446);
            panel2.TabIndex = 1;
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveBook.AutoSize = true;
            btnRemoveBook.FlatStyle = FlatStyle.Flat;
            btnRemoveBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveBook.ForeColor = Color.White;
            btnRemoveBook.Location = new Point(5, 94);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(170, 38);
            btnRemoveBook.TabIndex = 2;
            btnRemoveBook.Text = "Remove a Book";
            btnRemoveBook.UseVisualStyleBackColor = true;
            btnRemoveBook.Click += btnRemoveBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateBook.AutoSize = true;
            btnUpdateBook.FlatStyle = FlatStyle.Flat;
            btnUpdateBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBook.ForeColor = Color.White;
            btnUpdateBook.Location = new Point(5, 50);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(170, 38);
            btnUpdateBook.TabIndex = 1;
            btnUpdateBook.Text = "Update a Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnCreateBook
            // 
            btnCreateBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateBook.FlatStyle = FlatStyle.Flat;
            btnCreateBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateBook.ForeColor = Color.White;
            btnCreateBook.Location = new Point(5, 6);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(170, 38);
            btnCreateBook.TabIndex = 0;
            btnCreateBook.Text = "Create a Book";
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(5, 405);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btnSearchBook);
            groupBox1.Controls.Add(lblBookDescription);
            groupBox1.Controls.Add(txtBookDescriptionSearch);
            groupBox1.Controls.Add(txtBookNameSearch);
            groupBox1.Controls.Add(lblBookName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1263, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Criteria";
            // 
            // btnSearchBook
            // 
            btnSearchBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchBook.AutoSize = true;
            btnSearchBook.FlatStyle = FlatStyle.Flat;
            btnSearchBook.ForeColor = Color.White;
            btnSearchBook.Location = new Point(1104, 70);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(153, 38);
            btnSearchBook.TabIndex = 2;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Location = new Point(6, 76);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(160, 26);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Book Description";
            // 
            // txtBookDescriptionSearch
            // 
            txtBookDescriptionSearch.BackColor = Color.Black;
            txtBookDescriptionSearch.ForeColor = Color.White;
            txtBookDescriptionSearch.Location = new Point(178, 73);
            txtBookDescriptionSearch.Name = "txtBookDescriptionSearch";
            txtBookDescriptionSearch.Size = new Size(460, 33);
            txtBookDescriptionSearch.TabIndex = 1;
            // 
            // txtBookNameSearch
            // 
            txtBookNameSearch.BackColor = Color.Black;
            txtBookNameSearch.ForeColor = Color.White;
            txtBookNameSearch.Location = new Point(178, 36);
            txtBookNameSearch.Name = "txtBookNameSearch";
            txtBookNameSearch.Size = new Size(460, 33);
            txtBookNameSearch.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(6, 39);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(111, 26);
            lblBookName.TabIndex = 0;
            lblBookName.Text = "Book Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(groupBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 81);
            panel5.Name = "panel5";
            panel5.Size = new Size(1263, 116);
            panel5.TabIndex = 0;
            // 
            // frmBookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1263, 643);
            Controls.Add(dgvBookList);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmBookManagement";
            Text = "Book Management";
            WindowState = FormWindowState.Maximized;
            Load += frmBookManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox picBoxLogo;
        private Label lblLibraryManagement;
        private Panel panel3;
        private DataGridView dgvBookList;
        private Panel panel2;
        private Button btnRemoveBook;
        private Button btnUpdateBook;
        private Button btnCreateBook;
        private Button btnBack;
        private GroupBox groupBox1;
        private Button btnSearchBook;
        private Label lblBookDescription;
        private TextBox txtBookDescriptionSearch;
        private TextBox txtBookNameSearch;
        private Label lblBookName;
        private Panel panel5;
    }
}