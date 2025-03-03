using System.ComponentModel.DataAnnotations;

namespace YourProjectName.Entities
{
    public class Book
    {
        public int Id { get; set; } // This is my primary key
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; } // This image URL is  for the book cover picture
        public int GenreId { get; set; }
        public Genre Genre { get; set; } // Navigation property
    }
}