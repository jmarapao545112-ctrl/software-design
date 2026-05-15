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
            groupBox1.Location = new Point(555, 321);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(408, 172);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Operations";
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(106, 92);
            btnImportBooks.Margin = new Padding(3, 4, 3, 4);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(203, 31);
            btnImportBooks.TabIndex = 1;
            btnImportBooks.Text = "Import Books ";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(106, 41);
            btnExportBooks.Margin = new Padding(3, 4, 3, 4);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(203, 31);
            btnExportBooks.TabIndex = 0;
            btnExportBooks.Text = "Export Books ";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(listBoxBooks);
            groupBox2.Location = new Point(25, 29);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(513, 325);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Inventory";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(7, 29);
            listBoxBooks.Margin = new Padding(3, 4, 3, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(499, 284);
            listBoxBooks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 4;
            label1.Text = "Search by Title:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(662, 25);
            txtSearchTitle.Margin = new Padding(3, 4, 3, 4);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(301, 27);
            txtSearchTitle.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(878, 64);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
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
            groupBox4.Location = new Point(25, 363);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(513, 131);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pagination";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(353, 45);
            btnNextPage.Margin = new Padding(3, 4, 3, 4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(123, 31);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next Page ->";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(207, 51);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(44, 20);
            lblPageNumber.TabIndex = 1;
            lblPageNumber.Text = "Page:";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(29, 45);
            btnPreviousPage.Margin = new Padding(3, 4, 3, 4);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(123, 31);
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
            groupBox3.Location = new Point(555, 123);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(408, 175);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add New Book";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(273, 120);
            btnAddBook.Margin = new Padding(3, 4, 3, 4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(86, 31);
            btnAddBook.TabIndex = 11;
            btnAddBook.Text = "Save Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(126, 81);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(233, 27);
            txtAuthor.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(126, 40);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(233, 27);
            txtTitle.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 85);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 9;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 44);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 8;
            label2.Text = "Title:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(987, 508);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchTitle);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
