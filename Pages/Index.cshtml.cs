using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BugTrackerv2.Pages
{
    public class IndexModel : PageModel
    {
        //Fields
        private readonly ILogger<IndexModel> _logger;

        //Constructor - injected IConfiguration resolve the user credentials from appSettings.
        public IndexModel(ILogger<IndexModel> logger)
        {
            this._logger = logger;

        }

        //Http Get request Method
        public void OnGet()
        {

        }


    }
}
