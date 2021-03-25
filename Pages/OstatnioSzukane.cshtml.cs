using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWWW.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWWW.Pages
{
    public class OstatnioSzukaneModel : PageModel
    {

        public FizzBuzz FizzBuzz;

        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("SessionFizzBuzz");
            if (SessionFizzBuzz != null)
            {
                FizzBuzz =
                  JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzBuzz);
            }
        }
        


    }
}

