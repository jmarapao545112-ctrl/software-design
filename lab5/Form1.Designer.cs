namespace lab5
{
	partial class BookStore
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
            label1 = new Label();
            txtBookId = new TextBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnUpdateBook = new Button();
            btnShowBooks = new Button();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(490, 43);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 9;
            label1.Text = "Information:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(490, 79);
            txtBookId.Name = "txtBookId";
            txtBookId.PlaceholderText = "Book ID";
            txtBookId.Size = new Size(261, 27);
            txtBookId.TabIndex = 10;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(490, 128);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(261, 27);
            txtBookTitle.TabIndex = 11;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(490, 180);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name";
            txtAuthorName.Size = new Size(261, 27);
            txtAuthorName.TabIndex = 12;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.AliceBlue;
            btnAddBook.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBook.Location = new Point(490, 310);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(120, 31);
            btnAddBook.TabIndex = 13;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(35, 43);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(405, 364);
            listBoxBooks.TabIndex = 14;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.Green;
            btnUpdateBook.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateBook.Location = new Point(631, 310);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(120, 31);
            btnUpdateBook.TabIndex = 15;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.BackColor = Color.AliceBlue;
            btnShowBooks.Location = new Point(490, 366);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(120, 31);
            btnShowBooks.TabIndex = 16;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = false;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Firebrick;
            btnDeleteBook.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteBook.Location = new Point(631, 366);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(120, 31);
            btnDeleteBook.TabIndex = 17;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // BookStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnShowBooks);
            Controls.Add(btnUpdateBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookId);
            Controls.Add(label1);
            Name = "BookStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBookId;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnUpdateBook;
        private Button btnShowBooks;
        private Button btnDeleteBook;
    }
}
