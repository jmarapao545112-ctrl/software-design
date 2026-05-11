namespace lab6
{
	partial class Form1
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
            lstboxBooks = new ListBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtBookId = new TextBox();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnAddBook = new Button();
            label2 = new Label();
            label1 = new Label();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnFetchBooks = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstboxBooks
            // 
            lstboxBooks.BackColor = Color.Snow;
            lstboxBooks.FormattingEnabled = true;
            lstboxBooks.Location = new Point(55, 36);
            lstboxBooks.Margin = new Padding(3, 4, 3, 4);
            lstboxBooks.Name = "lstboxBooks";
            lstboxBooks.Size = new Size(399, 484);
            lstboxBooks.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(btnFetchBooks);
            groupBox1.Location = new Point(487, 36);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(400, 484);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 181);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "Book ID:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(98, 175);
            txtBookId.Margin = new Padding(3, 4, 3, 4);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(228, 27);
            txtBookId.TabIndex = 8;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Red;
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(208, 344);
            btnDeleteBook.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(112, 52);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.AutoSize = true;
            btnUpdateBook.BackColor = Color.ForestGreen;
            btnUpdateBook.ForeColor = Color.WhiteSmoke;
            btnUpdateBook.Location = new Point(77, 345);
            btnUpdateBook.Margin = new Padding(3, 4, 3, 4);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(121, 52);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.AutoSize = true;
            btnAddBook.BackColor = Color.Turquoise;
            btnAddBook.ForeColor = Color.Black;
            btnAddBook.Location = new Point(77, 289);
            btnAddBook.Margin = new Padding(3, 4, 3, 4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(121, 48);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 117);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Book:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Author:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(98, 111);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(228, 27);
            txtBookTitle.TabIndex = 2;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(98, 55);
            txtAuthorName.Margin = new Padding(3, 4, 3, 4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(228, 27);
            txtAuthorName.TabIndex = 1;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.AutoSize = true;
            btnFetchBooks.BackColor = Color.Orange;
            btnFetchBooks.Location = new Point(208, 289);
            btnFetchBooks.Margin = new Padding(3, 4, 3, 4);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(112, 48);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = false;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(943, 550);
            Controls.Add(groupBox1);
            Controls.Add(lstboxBooks);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstboxBooks;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtBookId;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private Label label2;
        private Label label1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnFetchBooks;
    }
}
