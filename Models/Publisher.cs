using System.ComponentModel.DataAnnotations;

namespace Rasiga_Camelia_Lab2_1.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
