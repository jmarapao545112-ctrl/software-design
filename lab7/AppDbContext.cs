using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connects to LocalDB
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookInventoryDB;Trusted_Connection=True;");
        }
    }
}