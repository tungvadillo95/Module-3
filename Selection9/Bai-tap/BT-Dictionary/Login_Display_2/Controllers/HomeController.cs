using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Login_Display_2.Models;

namespace Login_Display_2.Controllers
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
        public IActionResult OnPost(DictionaryModel model)
        {
            bool isMatched = false;
            foreach (var item in model.libs)
            {
                if (item.Key == model.word)
                {
                    isMatched = true;
                    ViewData["result"] = "English: " + item.Key + "_________" + "Việt Nam: " + item.Value;
                }
            }
            if (!isMatched)
            {
                ViewData["result"] = "Find not found!";
            }
           return View("~/Views/Home/Index.cshtml");
        }
    }
}
