using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InternationalizationWeb.Models;
using Microsoft.Extensions.Localization;

namespace InternationalizationWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)

        {

            _localizer = localizer;

        }

        public IActionResult Index()

        {

            ViewData["Message"] = _localizer["TestString"];

            return View();

        }

        public IActionResult About()

        {

            return View();

        }

        public IActionResult Contact()

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
    }
}
