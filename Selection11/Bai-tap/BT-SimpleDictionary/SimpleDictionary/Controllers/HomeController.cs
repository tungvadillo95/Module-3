using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleDictionary.Models;

namespace SimpleDictionary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Translate(DictionaryModel model)
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
