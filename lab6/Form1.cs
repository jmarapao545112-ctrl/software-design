using Microsoft.EntityFrameworkCore;
using System;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public virtual Author Author { get; set; }
        }

        private async Task<List<string>> GetBooksAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                // First, get the raw list of books from the database
                var books = await context.Books.Include(b => b.Author).ToListAsync();
                var formattedBooks = new List<string>();

                // Loop through the books to format them and report progress
                for (int i = 0; i < books.Count; i++)
                {
                    var b = books[i];
                    formattedBooks.Add($"{b.BookId} - {b.Title} by {b.Author.Name}");

                    // Simulate a slightly heavy workload so you can actually see the progress bar move
                    await Task.Delay(200);

                    // Calculate the percentage completed and report it
                    if (progress != null)
                    {
                        int percentage = ((i + 1) * 100) / books.Count;
                        progress.Report(percentage);
                    }
                }

                return formattedBooks;
            }
        }

        private async Task SaveBookAsync(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateBookAsync()
        {
            using (var context = new BookstoreContext())
            {
                if (int.TryParse(txtBookId.Text, out int bookId))
                {
                    var book = await context.Books
                                            .Include(b => b.Author)
                                            .FirstOrDefaultAsync(b => b.BookId == bookId);

                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;

                        if (book.Author != null)
                        {
                            book.Author.Name = txtAuthorName.Text;
                        }

                        await context.SaveChangesAsync();
                        MessageBox.Show("Book updated successfully!");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Book not found in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please enter a valid number.");
                }
            }
        }

        private async Task DeleteBookAsync()
        {
            using (var context = new BookstoreContext())
            {
                if (int.TryParse(txtBookId.Text, out int bookId))
                {
                    var book = await context.Books.FindAsync(bookId);
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book deleted successfully!");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Book not found in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please enter a valid number.");
                }
            }
        }

        public async void LoadList()
        {
            var booksWithAuthors = await GetBooksAsync(null);
            lstboxBooks.DataSource = booksWithAuthors;
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookName = txtBookTitle.Text;
            string authorName = txtAuthorName.Text;

            btnAddBook.Enabled = false;

            await SaveBookAsync(authorName, bookName);
            MessageBox.Show("Book and Author added successfully!");
            LoadList();

            btnAddBook.Enabled = true;
        }

        private void btnFetchBooks_Click(object sender, EventArgs e)
        {
            btnFetchBooks.Enabled = false;
            progressBar1.Value = 0;

            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;
            });

            try
            {
                var booksWithAuthors = await GetBooksAsync(progress);
                lstboxBooks.DataSource = booksWithAuthors;
            }
            finally
            {
                btnFetchBooks.Enabled = true;
                progressBar1.Value = 100;
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            await UpdateBookAsync();
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            await DeleteBookAsync();
        }

        private void lstboxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxBooks.SelectedItem != null)
            {
                string selectedItem = lstboxBooks.SelectedItem.ToString();

                string[] parts = selectedItem.Split(new string[] { " - ", " by " }, StringSplitOptions.None);

                if (parts.Length >= 1)
                {
                    txtBookId.Text = parts[0];
                }
                if (parts.Length >= 2)
                {
                    txtBookTitle.Text = parts[1];
                }
                if (parts.Length >= 3)
                {
                    txtAuthorName.Text = parts[2];
                }
            }
        }

        private async Task<List<string>> SearchBooksAsync(string searchKeyword)
        {
            using (var context = new BookstoreContext())
            {
                var searchResults = await context.Books
                                                 .Include(b => b.Author)
                                                 .Where(b => b.Title.Contains(searchKeyword))
                                                 .Select(b => $"{b.BookId} - {b.Title} by {b.Author.Name}")
                                                 .ToListAsync();
                return searchResults;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a title to search for.");
                return;
            }

            btnSearch.Enabled = false;
            var results = await SearchBooksAsync(keyword);
            lstboxBooks.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No books found with that title.");
            }

            btnSearch.Enabled = true;
        }
    }
}
