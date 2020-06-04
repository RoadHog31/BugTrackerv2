using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BugTrackerv2.Data;
using BugTrackerv2.Models;
using Microsoft.AspNetCore.Authorization;

namespace BugTrackerv2.Pages.Bugs
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly BugTrackerv2.Data.ApplicationDbContext _context;

        public DetailsModel(BugTrackerv2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Bug Bug { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bug = await _context.BugForms.FirstOrDefaultAsync(m => m.BugId == id);

            if (Bug == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
