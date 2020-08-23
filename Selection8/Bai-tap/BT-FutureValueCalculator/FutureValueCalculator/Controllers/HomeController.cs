﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FutureValueCalculator.Models;

namespace FutureValueCalculator.Controllers
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
            var count = model.NumberofYears;
            while (count > 0)
            {
                model.FutureValue += (model.InventmentAmount * model.YearlyInterestRate /100);
                count--;
            }
            model.FutureValue = model.FutureValue + model.InventmentAmount;
            return View("~/Views/Home/Index.cshtml", model);
        }
    }
}
