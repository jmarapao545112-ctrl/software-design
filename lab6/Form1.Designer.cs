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
            progressBar1 = new ProgressBar();
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstboxBooks
            // 
            lstboxBooks.BackColor = Color.Snow;
            lstboxBooks.FormattingEnabled = true;
            lstboxBooks.ItemHeight = 15;
            lstboxBooks.Location = new Point(48, 72);
            lstboxBooks.Name = "lstboxBooks";
            lstboxBooks.Size = new Size(350, 319);
            lstboxBooks.TabIndex = 2;
            lstboxBooks.SelectedIndexChanged += lstboxBooks_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(progressBar1);
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
            groupBox1.Location = new Point(426, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 363);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(67, 314);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(213, 23);
            progressBar1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 136);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Book ID:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(86, 131);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(200, 23);
            txtBookId.TabIndex = 8;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Red;
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(182, 258);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(98, 39);
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
            btnUpdateBook.Location = new Point(67, 259);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(106, 39);
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
            btnAddBook.Location = new Point(67, 217);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(106, 36);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Book:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 46);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Author:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(86, 83);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(200, 23);
            txtBookTitle.TabIndex = 2;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(86, 41);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(200, 23);
            txtAuthorName.TabIndex = 1;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.AutoSize = true;
            btnFetchBooks.BackColor = Color.Orange;
            btnFetchBooks.Location = new Point(182, 217);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(98, 36);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = false;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(48, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(170, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(234, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(825, 412);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(groupBox1);
            Controls.Add(lstboxBooks);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ProgressBar progressBar1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
