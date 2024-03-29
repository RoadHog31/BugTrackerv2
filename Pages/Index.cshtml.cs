﻿using System;
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

namespace BugTrackerv2.Pages.Bugs
{
    [Authorize]
    public class IndexModel : PageModel
    {
        //Fields
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        //Properties
        //SearchString contains the text users enter in the search text box. SearchString has the [BindProperty] attribute. [BindProperty] binds form values and query strings with the same name as the property. (SupportsGet = true) is required for binding on GET requests.
        [TempData]
        public string MainSearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        //contains the specific bugtype the user selects (for example, "Website").
        [BindProperty(SupportsGet = true)]
        public string BugType { get; set; }      

        [BindProperty(SupportsGet = true)]
        public string AssigneeSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        //I changed the type of the Bugs property from IList<Bugs> to PaginatedList<Bugs>.
        public PaginatedList<Bug> Bugs { get; set; }

        public IList<Bug> Bug { get; set; }

        //Constructor - injected IConfiguration resolve the user credentials from appSettings.
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            this._logger = logger;
            this._context = context;

        }

        //public IActionResult OnGet()
        //{
        //    return Page();

        //}
        public IActionResult OnPost()
        {
            try
            {
                if (!string.IsNullOrEmpty(SearchString))

                    MainSearchString = SearchString.ToString().ToUpper();
                return RedirectToPage("Bugs/Home");
            }
            catch (FormatException)
            {
                ModelState.AddModelError("SearchString", "Invalid search term");
                return Page();
            }
        }       

        

        //Adds the page index, the current sortOrder, and the currentFilter to the OnGetAsync method signature.
        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter, int? pageIndex)
        {
            //Saves the sort order in the CurrentSort property.
            CurrentSort = sortOrder;
            //Filtering starts here. 
            AssigneeSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            //Resets page index to 1 when there's a new search string.
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

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

            //Uses the PaginatedList class to get Bug entities.
            //The PaginatedList.CreateAsync method converts the bugs query to a single page of bugs in a collection type that supports paging. That single page of bugs is passed to the Razor Page.
            int pageSize = 3;
            Bugs = await PaginatedList<Bug>.CreateAsync(
                bugItem.AsNoTracking(), pageIndex ?? 1, pageSize);
            //Filtering ends here.
        }

        //Http Get request Method - The first line of the OnGetAsync method creates a LINQ query to select the bugs:
        public IActionResult OnGetFilter()
        {
            //If the MainSearchString TempData property is not null or empty, the bugs query is modified to filter on the search string from mainpage:
            if (!string.IsNullOrEmpty(MainSearchString))
            {
                // using System.Linq;
                IQueryable<Bug> bugItem = from s in _context.BugForms
                                          select s;

                //Use of a Lambda Expression. 
                var bugs = bugItem.Where(s => s.Title.ToUpper().Contains(MainSearchString.ToUpper()) || s.Assignee.ToUpper().Contains(MainSearchString.ToUpper()));

                Bugs = (PaginatedList<Bug>)bugs.ToList();
            }

            return Page();
        }
    }
}
