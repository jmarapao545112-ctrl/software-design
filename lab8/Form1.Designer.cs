namespace lab8
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
            lbxApiResults = new ListBox();
            groupBox3 = new GroupBox();
            txtBookDetails = new TextBox();
            btnFetchBook = new Button();
            label3 = new Label();
            txtISBN = new TextBox();
            groupBox2 = new GroupBox();
            lblApiPage = new Label();
            btnApiPrev = new Button();
            btnApiNext = new Button();
            label1 = new Label();
            txtAuthorSearch = new TextBox();
            btnSearchAuthor = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(lbxApiResults);
            groupBox1.Location = new Point(28, 69);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(424, 502);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Inventory";
            // 
            // lbxApiResults
            // 
            lbxApiResults.FormattingEnabled = true;
            lbxApiResults.Location = new Point(7, 29);
            lbxApiResults.Margin = new Padding(3, 4, 3, 4);
            lbxApiResults.Name = "lbxApiResults";
            lbxApiResults.Size = new Size(410, 464);
            lbxApiResults.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Thistle;
            groupBox3.Controls.Add(txtBookDetails);
            groupBox3.Controls.Add(btnFetchBook);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtISBN);
            groupBox3.Location = new Point(474, 22);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(456, 451);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "ISBN Lookup";
            // 
            // txtBookDetails
            // 
            txtBookDetails.Location = new Point(24, 75);
            txtBookDetails.Margin = new Padding(3, 4, 3, 4);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.ScrollBars = ScrollBars.Vertical;
            txtBookDetails.Size = new Size(415, 365);
            txtBookDetails.TabIndex = 8;
            // 
            // btnFetchBook
            // 
            btnFetchBook.BackColor = Color.DarkSeaGreen;
            btnFetchBook.Location = new Point(354, 36);
            btnFetchBook.Margin = new Padding(3, 4, 3, 4);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(86, 31);
            btnFetchBook.TabIndex = 5;
            btnFetchBook.Text = "Fetch";
            btnFetchBook.UseVisualStyleBackColor = false;
            btnFetchBook.Click += btnFetchBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 41);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(71, 36);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(262, 27);
            txtISBN.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.GhostWhite;
            groupBox2.Controls.Add(lblApiPage);
            groupBox2.Controls.Add(btnApiPrev);
            groupBox2.Controls.Add(btnApiNext);
            groupBox2.Location = new Point(474, 481);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(456, 90);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pagination";
            // 
            // lblApiPage
            // 
            lblApiPage.AutoSize = true;
            lblApiPage.Location = new Point(190, 33);
            lblApiPage.Name = "lblApiPage";
            lblApiPage.Size = new Size(44, 20);
            lblApiPage.TabIndex = 4;
            lblApiPage.Text = "Page:";
            // 
            // btnApiPrev
            // 
            btnApiPrev.BackColor = SystemColors.ControlLight;
            btnApiPrev.Location = new Point(24, 27);
            btnApiPrev.Margin = new Padding(3, 4, 3, 4);
            btnApiPrev.Name = "btnApiPrev";
            btnApiPrev.Size = new Size(147, 31);
            btnApiPrev.TabIndex = 2;
            btnApiPrev.Text = "<- Previous Page";
            btnApiPrev.UseVisualStyleBackColor = false;
            btnApiPrev.Click += btnApiPrev_Click;
            // 
            // btnApiNext
            // 
            btnApiNext.BackColor = SystemColors.ControlLight;
            btnApiNext.Location = new Point(314, 27);
            btnApiNext.Margin = new Padding(3, 4, 3, 4);
            btnApiNext.Name = "btnApiNext";
            btnApiNext.Size = new Size(131, 31);
            btnApiNext.TabIndex = 0;
            btnApiNext.Text = "Next Page ->";
            btnApiNext.UseVisualStyleBackColor = false;
            btnApiNext.Click += btnApiNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 9;
            label1.Text = "Search by Author:";
            // 
            // txtAuthorSearch
            // 
            txtAuthorSearch.Location = new Point(159, 22);
            txtAuthorSearch.Margin = new Padding(3, 4, 3, 4);
            txtAuthorSearch.Name = "txtAuthorSearch";
            txtAuthorSearch.Size = new Size(199, 27);
            txtAuthorSearch.TabIndex = 10;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.BackColor = Color.PowderBlue;
            btnSearchAuthor.Location = new Point(366, 20);
            btnSearchAuthor.Margin = new Padding(3, 4, 3, 4);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(86, 31);
            btnSearchAuthor.TabIndex = 11;
            btnSearchAuthor.Text = "Search";
            btnSearchAuthor.UseVisualStyleBackColor = false;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(958, 584);
            Controls.Add(btnSearchAuthor);
            Controls.Add(txtAuthorSearch);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lbxApiResults;
        private GroupBox groupBox3;
        private TextBox txtBookDetails;
        private Button btnFetchBook;
        private Label label3;
        private TextBox txtISBN;
        private GroupBox groupBox2;
        private Label lblApiPage;
        private Button btnApiPrev;
        private Button btnApiNext;
        private Label label1;
        private TextBox txtAuthorSearch;
        private Button btnSearchAuthor;
    }
}
