using System.ComponentModel.DataAnnotations;

namespace BookValidationApp.Models
{
    public class Book
    {
        [Required(ErrorMessage = "ISBN is required")]
        public int Isbn { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Book name must be between 1 and 20 characters")]
        public string BookName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Author name must be between 1 and 50 characters")]
        public string AuthorName { get; set; }

        [NotFutureDate(ErrorMessage = "Published date cannot be in the future")]
        public DateTime PublishedDate { get; set; }

        [Url(ErrorMessage = "Invalid Book URL")]
        public string BookUrl { get; set; }
    }
}

