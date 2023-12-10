﻿using System.ComponentModel.DataAnnotations;

namespace Rasiga_Camelia_Lab2_1.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        public int? BookID { get; set; }
        public Book? Book { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }
    }
}
