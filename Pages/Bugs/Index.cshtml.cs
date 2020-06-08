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

        public string AssigneeSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Bug> Bugs { get; set; }

        public IndexModel(BugTrackerv2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            //Get full list of bugs for indexing in view. 
            Bugs = await _context.BugForms.ToListAsync();

            CurrentFilter = searchString;

            //Filtering starts here. 
            AssigneeSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Bug> bugItem = from s in _context.BugForms
                                      select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                bugItem = bugItem.Where(b => b.Title.ToUpper().Contains(searchString.ToUpper()) || b.Assignee.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    bugItem = bugItem.OrderByDescending(s => s.Assignee);
                    break;
                case "Date":
                    bugItem = bugItem.OrderBy(s => s.DateCreated);
                    break;
                case "date_desc":
                    bugItem = bugItem.OrderByDescending(s => s.DateCreated);
                    break;
                default:
                    bugItem = bugItem.OrderBy(s => s.Assignee);
                    break;
            }

            Bugs = await bugItem.AsNoTracking().ToListAsync();
            //Filtering ends here.
        }




    }
}
