using System.ComponentModel.DataAnnotations;

namespace lab7
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string DisplayText => $"{Title} - {Author}";
    }
}