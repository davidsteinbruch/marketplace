namespace Marketplace.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }
        
        public Book(long id, string title, string description, string author, string image, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Image = image;
            Price = price;
        }
    }
}
