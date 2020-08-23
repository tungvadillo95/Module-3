using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Login_Display_1.Models;

namespace Login_Display_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult OnPost(IndexModel model)
        {
            if (model.Username == null || model.Password == null)
            {
                return View("~/Views/Home/Index.cshtml");
            }
            else if (model.Username == "admin" && model.Password == "123123")
            {
                return View("~/Views/Home/HomeIndex.cshtml", model);
            }
            else
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}
