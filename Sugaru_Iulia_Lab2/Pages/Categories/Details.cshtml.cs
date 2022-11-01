using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sugaru_Iulia_Lab2.Data;
using Sugaru_Iulia_Lab2.Models;

namespace Sugaru_Iulia_Lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Sugaru_Iulia_Lab2.Data.Sugaru_Iulia_Lab2Context _context;

        public DetailsModel(Sugaru_Iulia_Lab2.Data.Sugaru_Iulia_Lab2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
