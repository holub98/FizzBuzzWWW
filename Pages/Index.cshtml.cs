using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWWW.Models;

namespace FizzBuzzWWW.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet =true)]
        public FizzBuzz FizzBuzz { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionFizzBuzz",
JsonConvert.SerializeObject(FizzBuzz));

                return Page();
            }
            return Page();
        }
    }
}
