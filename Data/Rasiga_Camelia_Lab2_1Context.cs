using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rasiga_Camelia_Lab2_1.Models;

namespace Rasiga_Camelia_Lab2_1.Data
{
    public class Rasiga_Camelia_Lab2_1Context : DbContext
    {
        public Rasiga_Camelia_Lab2_1Context (DbContextOptions<Rasiga_Camelia_Lab2_1Context> options)
            : base(options)
        {
        }

        public DbSet<Rasiga_Camelia_Lab2_1.Models.Book> Book { get; set; } = default!;

        public DbSet<Rasiga_Camelia_Lab2_1.Models.Publisher>? Publisher { get; set; }

        public DbSet<Rasiga_Camelia_Lab2_1.Models.Author>? Author { get; set; }

        public DbSet<Rasiga_Camelia_Lab2_1.Models.Category>? Category { get; set; }

        public DbSet<Rasiga_Camelia_Lab2_1.Models.BookCategory>? BookCategory { get; set; }

        public DbSet<Rasiga_Camelia_Lab2_1.Models.Member>? Member { get; set; }

        public DbSet<Borrowing>? Borrowing { get; set; }
    }
}
