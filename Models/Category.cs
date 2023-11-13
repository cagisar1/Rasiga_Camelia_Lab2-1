using System.ComponentModel.DataAnnotations;

namespace Rasiga_Camelia_Lab2_1.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name ="Category Name")]
        public string CategoryName {  get; set; }
      
        public ICollection<BookCategory>? BookCategories { get; set; }

        //am modificat randul de mai jos!
        public ICollection<AssignedCategoryData> AssignedCategories { get; set; }

    }
}
