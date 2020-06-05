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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BugTrackerv2.Pages.Bugs
{

    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly BugTrackerv2.Data.ApplicationDbContext _context;

        //Properties
        //contains the text users enter in the search text box. SearchString has the [BindProperty] attribute. [BindProperty] binds form values and query strings with the same name as the property. (SupportsGet = true) is required for binding on GET requests.
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IList<Bug> Bug { get; set; }

        public IndexModel(BugTrackerv2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Bug = await _context.BugForms.ToListAsync();
        }

        public async Task OnGetAsyncFilter()
        {
            // Use LINQ to get list of bugs.         

            var bugs = from m in _context.BugForms
                       select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                //A Lambda Expression. 
                bugs = bugs.Where(s => s.BugType.Contains(SearchString));
            }


            //Bug = await bugs.ToListAsync();
            Bug = await bugs.ToListAsync();
        }
    }
}
