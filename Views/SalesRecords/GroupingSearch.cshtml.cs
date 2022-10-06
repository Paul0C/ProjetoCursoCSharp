using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SalesWebMvc.Views.SalesRecords
{
    public class GroupingSearch : PageModel
    {
        private readonly ILogger<GroupingSearch> _logger;

        public GroupingSearch(ILogger<GroupingSearch> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}