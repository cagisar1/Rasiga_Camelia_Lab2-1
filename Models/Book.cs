using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rasiga_Camelia_Lab2_1.Models
{
    public class Book
    {
        public int ID {  get; set; }
        [Display(Name = "Book Title")]
        [StringLength(150, MinimumLength = 3, ErrorMessage =
"Titlul cartii trebuie sa aiba un numar de caractere cuprins intre 3-150")]
        [Required]
        public string Title {  get; set; }
        public int? AuthorID {  get; set; }

        public Author? Author { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        [Range(0.01, 500)]
        public decimal Price {  get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate {  get; set; }
        [Display(Name = "Publisher ID")]
        public int? PublisherID {  get; set; }
        public Publisher? Publisher { get; set; }

        public Borrowing? Borrowing { get; set; }

        [Display(Name = "Book Category")]
        public ICollection<BookCategory>? BookCategories { get; set;}
    }
}
