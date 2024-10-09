namespace BookManager
{
    partial class frmEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditBook));
            panel1 = new Panel();
            label3 = new Label();
            picBoxLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtId = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtPulicationDate = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtAuthor = new TextBox();
            txtCategoryId = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDone = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1105, 81);
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 406);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 7;
            label5.Text = "Category Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 250);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 8;
            label6.Text = "Publication Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 289);
            label7.Name = "label7";
            label7.Size = new Size(93, 30);
            label7.TabIndex = 9;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 328);
            label8.Name = "label8";
            label8.Size = new Size(58, 30);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 367);
            label9.Name = "label9";
            label9.Size = new Size(77, 30);
            label9.TabIndex = 11;
            label9.Text = "Author";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Ink Free", 15.75F);
            txtId.Location = new Point(6, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(915, 33);
            txtId.TabIndex = 12;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Ink Free", 15.75F);
            txtTitle.Location = new Point(6, 52);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(915, 33);
            txtTitle.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Ink Free", 15.75F);
            txtDescription.Location = new Point(6, 91);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(915, 150);
            txtDescription.TabIndex = 14;
            // 
            // txtPulicationDate
            // 
            txtPulicationDate.BorderStyle = BorderStyle.FixedSingle;
            txtPulicationDate.Font = new Font("Ink Free", 15.75F);
            txtPulicationDate.Location = new Point(6, 247);
            txtPulicationDate.Name = "txtPulicationDate";
            txtPulicationDate.Size = new Size(915, 33);
            txtPulicationDate.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Ink Free", 15.75F);
            txtQuantity.Location = new Point(6, 286);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(915, 33);
            txtQuantity.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Ink Free", 15.75F);
            txtPrice.Location = new Point(6, 325);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(915, 33);
            txtPrice.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Font = new Font("Ink Free", 15.75F);
            txtAuthor.Location = new Point(6, 364);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(915, 33);
            txtAuthor.TabIndex = 18;
            // 
            // txtCategoryId
            // 
            txtCategoryId.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryId.Font = new Font("Ink Free", 15.75F);
            txtCategoryId.Location = new Point(6, 403);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(915, 33);
            txtCategoryId.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 543);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnDone);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(txtCategoryId);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtTitle);
            panel3.Controls.Add(txtAuthor);
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(txtPulicationDate);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(172, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(933, 543);
            panel3.TabIndex = 21;
            // 
            // btnDone
            // 
            btnDone.AutoSize = true;
            btnDone.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDone.Location = new Point(846, 495);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 36);
            btnDone.TabIndex = 20;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // frmEditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 624);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEditBook";
            Text = "Edit Book";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox picBoxLogo;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtId;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtPulicationDate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private TextBox txtCategoryId;
        private Panel panel2;
        private Panel panel3;
        private Button btnDone;
    }
}