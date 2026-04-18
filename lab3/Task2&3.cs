using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab3
{
    public partial class Task2_3 : Form
    {
        public Task2_3()
        {
            InitializeComponent();
        }

        public class Book
        {
            private string title;
            public string Title
            {
                get { return title; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Title cannot be empty.");
                    title = value;
                }
            }

            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            private int issueNum;
            public int IssueNum
            {
                get { return issueNum; }
                set
                {
                    if (value < 0) throw new ArgumentException("Issue number cannot be negative.");
                    issueNum = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNum}";
            }
        }

        public class EBook : Book
        {
            public double FileSizeMb { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - (Ebook - {FileSizeMb} MB)";
            }
        }

        private void ProcessBooks(Book[] books)
        {
            listBoxShow.Items.Clear();
            foreach (Book book in books)
            {
                listBoxShow.Items.Add(book.GetInfo());
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Book[] books =
                {
                    new Book { Title = "Clean Code", Author = "Robert C. Martin" },
                    new Magazine { Title = "Tech Weekly", IssueNum = 45 },
                    new EBook { Title = "C# in Depth", Author = "Jon Skeet", FileSizeMb = 5.2 },
                    new TextBook { Title = "Solving Integrals like a Pro", Subject = "Calculus" },
                    new AudioBook { Title = "The Lone Penguin", Narrator = "David Attenborough", Duration = 120 }
                };

            ProcessBooks(books);
        }

        public class TextBook : Book
        {
            private string subject;
            public string Subject
            {
                get { return subject; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Subject cannot be empty.");
                    subject = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} - {Subject} TextBook";
            }
        }

        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public int Duration { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - {Duration} minutes with {Narrator}";
            }
        }
    }
}