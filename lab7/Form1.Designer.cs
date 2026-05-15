namespace lab7
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
            groupBox1 = new GroupBox();
            btnImportBooks = new Button();
            btnExportBooks = new Button();
            groupBox2 = new GroupBox();
            listBoxBooks = new ListBox();
            label1 = new Label();
            txtSearchTitle = new TextBox();
            btnSearch = new Button();
            groupBox4 = new GroupBox();
            btnNextPage = new Button();
            lblPageNumber = new Label();
            btnPreviousPage = new Button();
            groupBox3 = new GroupBox();
            btnAddBook = new Button();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(btnImportBooks);
            groupBox1.Controls.Add(btnExportBooks);
            groupBox1.Location = new Point(486, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 129);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Operations";
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(93, 69);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(178, 23);
            btnImportBooks.TabIndex = 1;
            btnImportBooks.Text = "Import Books ";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(93, 31);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(178, 23);
            btnExportBooks.TabIndex = 0;
            btnExportBooks.Text = "Export Books ";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(listBoxBooks);
            groupBox2.Location = new Point(22, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 244);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Inventory";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(6, 22);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(437, 214);
            listBoxBooks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 4;
            label1.Text = "Search by Title:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(579, 19);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(264, 23);
            txtSearchTitle.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(768, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.GhostWhite;
            groupBox4.Controls.Add(btnNextPage);
            groupBox4.Controls.Add(lblPageNumber);
            groupBox4.Controls.Add(btnPreviousPage);
            groupBox4.Location = new Point(22, 272);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(449, 98);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pagination";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(309, 34);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(108, 23);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "<- Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(181, 38);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(36, 15);
            lblPageNumber.TabIndex = 1;
            lblPageNumber.Text = "Page:";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(25, 34);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(108, 23);
            btnPreviousPage.TabIndex = 0;
            btnPreviousPage.Text = "<- Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Thistle;
            groupBox3.Controls.Add(btnAddBook);
            groupBox3.Controls.Add(txtAuthor);
            groupBox3.Controls.Add(txtTitle);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(486, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(357, 131);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add New Book";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(239, 90);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 11;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(110, 61);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(204, 23);
            txtAuthor.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(110, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(204, 23);
            txtTitle.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 64);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 33);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Title:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(864, 381);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchTitle);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Management";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBoxBooks;
        private Button btnImportBooks;
        private Button btnExportBooks;
        private Label label1;
        private TextBox txtSearchTitle;
        private Button btnSearch;
        private GroupBox groupBox4;
        private Label lblPageNumber;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private GroupBox groupBox3;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Button btnAddBook;
    }
}
