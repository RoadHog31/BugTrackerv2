using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BugTrackerv2.Data;
using BugTrackerv2.Models;

namespace BugTrackerv2.Pages.Bugs
{

    public class IndexModel : PageModel
    {
        private readonly BugTrackerv2.Data.ApplicationDbContext _context;

        public IndexModel(BugTrackerv2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Bug> Bug { get; set; }

        public async Task OnGetAsync()
        {
            Bug = await _context.BugForms.ToListAsync();
        }
    }
}
