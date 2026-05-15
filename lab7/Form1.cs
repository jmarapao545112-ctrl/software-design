using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private int currentPage = 1;
        private const int pageSize = 10;

        public Form1()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadBooksAsync();
        }

        // TASK 1: PAGINATION
        private async Task LoadBooksAsync()
        {
            using (var context = new AppDbContext())
            {
                var books = await context.Books
                    .OrderBy(b => b.Id)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                listBoxBooks.DataSource = books;
                listBoxBooks.DisplayMember = "DisplayText";
                lblPageNumber.Text = $"Page: {currentPage}";

                btnPreviousPage.Enabled = currentPage > 1;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadBooksAsync();
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            await LoadBooksAsync();
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            await SaveBookAsync(txtTitle.Text, txtAuthor.Text);
        }

        private async Task SaveBookAsync(string title, string author)
        {
            if (string.IsNullOrWhiteSpace(title)) return;

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Books.Add(new Book { Title = title, Author = author });
                    await context.SaveChangesAsync();
                    MessageBox.Show("Book Saved!");
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    await LoadBooksAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving: {ex.Message}");
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var books = await context.Books.ToListAsync();
                    var content = books.Select(b => $"{b.Title}, {b.Author}");
                    await File.WriteAllLinesAsync("exported_books.txt", content);
                    MessageBox.Show("Exported to exported_books.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export failed: {ex.Message}");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = txtSearchTitle.Text.ToLower();
                    var results = await context.Books
                        .Where(b => b.Title.ToLower().Contains(query))
                        .ToListAsync();
                    listBoxBooks.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search Error: {ex.Message}");
            }
        }

        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("import.txt")) return;
                var lines = await File.ReadAllLinesAsync("import.txt");
                using (var context = new AppDbContext())
                {
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 2)
                            context.Books.Add(new Book { Title = parts[0].Trim(), Author = parts[1].Trim() });
                    }
                    await context.SaveChangesAsync();
                    await LoadBooksAsync();
                    MessageBox.Show("Import Success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Import Error: {ex.Message}");
            }
        }
    }
}
