using System.ComponentModel.DataAnnotations;

namespace Rasiga_Camelia_Lab2_1.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Display(Name ="First Name")]
        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = 
"Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau Ana Maria")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = 
"Prenumele trebuie sa aiba un numar de caractere cuprins intre 3-30")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = 
"Numele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau Ana-Maria")]
        [StringLength(30, MinimumLength = 3, ErrorMessage =
"Prenumele trebuie sa aiba un numar de caractere cuprins intre 3-30")]
        public string? LastName { get; set; }

        [StringLength(70, ErrorMessage = 
            "Adresa nu poate fi mai lunga de 70 de caractere!")]
        public string? Adress { get; set; }
        public string Email { get; set; }

        [RegularExpression(@"^([0]{1})([0-9]{3})[-. ]([0-9]{3})[-. ]([0-9]{3})$",
            ErrorMessage = "Telefonul trebuie sa inceapa cu cifra 0 si sa fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123'")]
        public string? Phone { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
