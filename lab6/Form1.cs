using Microsoft.EntityFrameworkCore;

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

        private async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                               .Select(b => $"{b.BookId} - {b.Title} by {b.Author.Name}")
                                               .ToListAsync();
                return books;
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
                    var book = await context.Books.FindAsync(bookId);
                    var author = await context.Authors.FindAsync(bookId);
                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;
                        author.Name = txtAuthorName.Text;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book updated successfully!");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID.");
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
                        MessageBox.Show("Book not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID.");
                }

            }
        }

        public async void LoadList()
        {
            var booksWithAuthors = await GetBooksAsync();
            lstboxBooks.DataSource = booksWithAuthors;
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookName = txtBookTitle.Text;
            string authorName = txtAuthorName.Text;
            await SaveBookAsync(authorName, bookName);
            MessageBox.Show("Book and Author added successfully!");
            LoadList();
        }

        private void btnFetchBooks_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            var context = new BookstoreContext();
            UpdateBookAsync();
            LoadList();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            var context = new BookstoreContext();
            DeleteBookAsync();
            LoadList();
        }
    }
}
