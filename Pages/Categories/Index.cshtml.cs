using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rasiga_Camelia_Lab2_1.Data;
using Rasiga_Camelia_Lab2_1.Models;
//using Rasiga_Camelia_Lab2_1.Models.ViewModels;

namespace Rasiga_Camelia_Lab2_1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Rasiga_Camelia_Lab2_1.Data.Rasiga_Camelia_Lab2_1Context _context;

        public IndexModel(Rasiga_Camelia_Lab2_1.Data.Rasiga_Camelia_Lab2_1Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }

    }
}
