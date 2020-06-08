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
        //SearchString contains the text users enter in the search text box. SearchString has the [BindProperty] attribute. [BindProperty] binds form values and query strings with the same name as the property. (SupportsGet = true) is required for binding on GET requests.
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        //contains the specific bugtype the user selects (for example, "Website").
        [BindProperty(SupportsGet = true)]
        public string BugType { get; set; }

        public IList<Bug> Bugs { get; set; }

        //Constructor - injected IConfiguration resolve the user credentials from appSettings.
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            this._logger = logger;
            this._context = context;

        }

        //Http Get request Method - The first line of the OnGetAsync method creates a LINQ query to select the bugs:
        public async Task<PageResult> OnGetAsync()
        {
            // using System.Linq;
            var bugs = from b in _context.BugForms
                       select b;

            //If the SearchString property is not null or empty, the bugs query is modified to filter on the search string:
            if (!string.IsNullOrEmpty(SearchString))
            {
                //Use of a Lambda Expression. 
                bugs = bugs.Where(s => s.Title.Contains(SearchString));
            }

            Bugs = await bugs.ToListAsync();

            return Page();

        }





    }
}
