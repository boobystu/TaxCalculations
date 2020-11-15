using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaxCalc;

namespace TaxSite.Pages
{
    public class ResultsModel : PageModel
    {
        public string TaxAmount;

        public void OnGet()
        {
            var calculator = new TaxCalculator();

            TaxAmount = calculator.Calculate(111, "1250L");
        }
    }
}