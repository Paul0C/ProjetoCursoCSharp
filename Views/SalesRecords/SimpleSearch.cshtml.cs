using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SalesWebMvc.Views.SalesRecords
{
    public class SimpleSearch : PageModel
    {
        private readonly ILogger<SimpleSearch> _logger;

        public SimpleSearch(ILogger<SimpleSearch> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}