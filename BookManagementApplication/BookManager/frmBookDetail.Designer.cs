namespace BookManager
{
    partial class frmBookDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookDetail));
            panel1 = new Panel();
            label3 = new Label();
            picBoxLogo = new PictureBox();
            groupBox1 = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPubicationDate = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtBookId = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTitle = new TextBox();
            label7 = new Label();
            txtAuthor = new TextBox();
            label8 = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnSave = new Button();
            label10 = new Label();
            btnClose = new Button();
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
            panel1.Size = new Size(1108, 81);
            panel1.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cboBookCategoryId);
            groupBox1.Controls.Add(dtpPubicationDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(987, 431);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(186, 387);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(162, 34);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPubicationDate
            // 
            dtpPubicationDate.Format = DateTimePickerFormat.Short;
            dtpPubicationDate.Location = new Point(186, 231);
            dtpPubicationDate.Name = "dtpPubicationDate";
            dtpPubicationDate.Size = new Size(162, 33);
            dtpPubicationDate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 110);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 23;
            label4.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 21;
            label1.Text = "Book Id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 71);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 22;
            label2.Text = "Title";
            // 
            // txtBookId
            // 
            txtBookId.BorderStyle = BorderStyle.FixedSingle;
            txtBookId.Font = new Font("Ink Free", 15.75F);
            txtBookId.Location = new Point(186, 32);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(786, 33);
            txtBookId.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 348);
            label9.Name = "label9";
            label9.Size = new Size(77, 30);
            label9.TabIndex = 28;
            label9.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 231);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 25;
            label6.Text = "Publication Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 387);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 24;
            label5.Text = "Category Id";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Ink Free", 15.75F);
            txtTitle.Location = new Point(186, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(786, 33);
            txtTitle.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 270);
            label7.Name = "label7";
            label7.Size = new Size(93, 30);
            label7.TabIndex = 26;
            label7.Text = "Quantity";
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Font = new Font("Ink Free", 15.75F);
            txtAuthor.Location = new Point(186, 348);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(786, 33);
            txtAuthor.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 306);
            label8.Name = "label8";
            label8.Size = new Size(58, 30);
            label8.TabIndex = 27;
            label8.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Ink Free", 15.75F);
            txtDescription.Location = new Point(186, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(786, 115);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Ink Free", 15.75F);
            txtPrice.Location = new Point(186, 309);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(162, 33);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Ink Free", 15.75F);
            txtQuantity.Location = new Point(186, 270);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(162, 33);
            txtQuantity.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(993, 213);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ink Free", 29.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 84);
            label10.Name = "label10";
            label10.Size = new Size(227, 49);
            label10.TabIndex = 38;
            label10.Text = "TextHeader";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(993, 252);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 36);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmBookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 606);
            Controls.Add(btnClose);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBookDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Detail";
            Load += frmBookDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox picBoxLogo;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private TextBox txtBookId;
        private Label label9;
        private Label label6;
        private Label label5;
        private TextBox txtTitle;
        private Label label7;
        private TextBox txtAuthor;
        private Label label8;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label10;
        private DateTimePicker dtpPubicationDate;
        private Button btnClose;
        private ComboBox cboBookCategoryId;
    }
}