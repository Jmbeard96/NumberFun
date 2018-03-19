using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NumberFunApp.Pages
{
    public class IndexModel : PageModel
    {

        private int number;

        public void OnGet()
        {
        }

        public void OnPost(){
            string number = Request.Form["number"];

        }
    }
}
