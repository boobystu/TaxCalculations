using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TaxSite.Pages
{
    public class IndexModel : PageModel
    {
        public string Salary => (string)(TempData[nameof(Salary)]);

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost([FromForm]string salary)
        {
            TempData["Salary"] = salary;
            return RedirectToPage("Results");
        }
    }
}
