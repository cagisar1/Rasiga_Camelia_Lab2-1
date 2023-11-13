using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rasiga_Camelia_Lab2_1.Data;
using Rasiga_Camelia_Lab2_1.Models;

namespace Rasiga_Camelia_Lab2_1.Pages.BookCategories
{
    public class DetailsModel : PageModel
    {
        private readonly Rasiga_Camelia_Lab2_1.Data.Rasiga_Camelia_Lab2_1Context _context;

        public DetailsModel(Rasiga_Camelia_Lab2_1.Data.Rasiga_Camelia_Lab2_1Context context)
        {
            _context = context;
        }

      public BookCategory BookCategory { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookCategory == null)
            {
                return NotFound();
            }

            var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);
            if (bookcategory == null)
            {
                return NotFound();
            }
            else 
            {
                BookCategory = bookcategory;
            }
            return Page();
        }
    }
}
