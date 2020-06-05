using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackerv2.Data;
using BugTrackerv2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BugTrackerv2.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        //Fields
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        //Properties
        //contains the text users enter in the search text box. SearchString has the [BindProperty] attribute. [BindProperty] binds form values and query strings with the same name as the property. (SupportsGet = true) is required for binding on GET requests.
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Bugs { get; set; }

        //contains the specific bugtype the user selects (for example, "Website").
        [BindProperty(SupportsGet = true)]
        public string BugType { get; set; }

        public IList<Bug> Bug { get; set; }

        //Constructor - injected IConfiguration resolve the user credentials from appSettings.
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            this._logger = logger;
            this._context = context;

        }

        //Http Get request Method  
        public IActionResult OnGet()
        {
            return Page();
        }


        public async Task<IActionResult> OnGetRead()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var bugs = from b in _context.BugForms
                       select b;

            if (!string.IsNullOrEmpty(SearchString))
            {
                //Use of a Lambda Expression. 
                bugs = bugs.Where(s => s.BugType.Contains(SearchString));
            }

            Bug = (IList<Bug>)await bugs.ToListAsync();

            //return Page();
            return new RedirectToPageResult("/Bugs/Index");
        }


    }
}
