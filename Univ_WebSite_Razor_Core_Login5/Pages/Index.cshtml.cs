using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Univ_WebSite_Razor_Core_Login5.Pages.data;

namespace Univ_WebSite_Razor_Core_Login5.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        IPriz _ipriz;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,IPriz ipriz)
        {
            _logger = logger;
            _ipriz = ipriz;
        }

        public void OnGet()
        {

         

           // TV tv = new TV(_ipriz);
           //string result =  tv.m1();

           // return Content(result);
        }
    }
}
