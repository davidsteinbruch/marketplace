using Microsoft.EntityFrameworkCore;

namespace Marketplace.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
    : base(options)
        {
            if(!Books.Any())
            {
                Books.AddRange(new Book(1, "Rich Dad Poor Dad", "What the Rich Teach Their Kids About Money That the Poor and Middle Class Do Not!", "Robert T. Kiyosaki", "https://images-na.ssl-images-amazon.com/images/I/51u8ZRDCVoL._SX330_BO1,204,203,200_.jpg", 9),
                    new Book(2, "Learn Microsoft Azure", "Build, manage, and scale cloud applications using the Azure ecosystem", "Mohamed Wali", "https://images-na.ssl-images-amazon.com/images/I/51hMZaeInaL._SX404_BO1,204,203,200_.jpg", 57));
                this.SaveChanges();
            }            
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
