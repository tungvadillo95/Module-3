using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Display_1.Models
{
    public class HomeModel : PageModel
    {
        private readonly ILogger _logger;

        public HomeModel(ILogger logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
