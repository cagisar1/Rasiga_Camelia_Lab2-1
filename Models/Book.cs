using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rasiga_Camelia_Lab2_1.Models
{
    public class Book
    {
        public int ID {  get; set; }
        [Display(Name = "Book Title")]
        public string Title {  get; set; }
        public int? AuthorID {  get; set; }

        public Author? Author { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price {  get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate {  get; set; }
        [Display(Name = "Publisher ID")]
        public int? PublisherID {  get; set; }
        public Publisher? Publisher { get; set; }

        [Display(Name = "Book Category")]
        public ICollection<BookCategory>? BookCategories { get; set;}
    }
}
