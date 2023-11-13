namespace Rasiga_Camelia_Lab2_1.Models
{
    public class AssignedCategoryData
    {
        public int ID { get; set; }
        public int CategoryID {  get; set; }

        //am modificat randul de mai jos!
        public Category? Category { get; set; }
        public string Name {  get; set; }
        public bool Assigned {  get; set; }
    }
}
