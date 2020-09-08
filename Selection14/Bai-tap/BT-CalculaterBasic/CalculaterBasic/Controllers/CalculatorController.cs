using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaterBasic.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculaterBasic.Controllers
{
    public class CalculatorController : Controller
    {
        private Calculator _calculator;
        private readonly CalculatorDbContext context;

        public CalculatorController(CalculatorDbContext context)
        {
            _calculator = new Calculator()
            {
                valueA = 0,
                valueB = 0,
                result = 0
            };
            this.context = context;
        }
        public IActionResult Calculate(Calculator model)
        {
            return View("~/Views/Calculator/Calculate.cshtml", model);
        }
        public IActionResult Addition(Calculator model)
        {
            ViewData["Name"] = "Addition";
            model.result = model.valueA + model.valueB;
            model.Operator = "+";
            context.calculators.Add(model);
            context.SaveChanges();
            return View("~/Views/Calculator/Calculate.cshtml", model);
        }
        public IActionResult Subtraction(Calculator model)
        {
            ViewData["Name"] = "Subtraction";
            model.result = model.valueA - model.valueB;
            model.Operator = "-";
            context.calculators.Add(model);
            context.SaveChanges();
            return View("~/Views/Calculator/Calculate.cshtml", model);
        }
        public IActionResult Multiplication(Calculator model)
        {
            ViewData["Name"] = "Multiplication";
            model.result = model.valueA * model.valueB;
            model.Operator = "x";
            context.calculators.Add(model);
            context.SaveChanges();
            return View("~/Views/Calculator/Calculate.cshtml", model);
        }
        public IActionResult Divison(Calculator model)
        {
            ViewData["Name"] = "Divison";
            model.result = model.valueA / model.valueB;
            model.Operator = "/";
            context.calculators.Add(model);
            context.SaveChanges();
            return View("~/Views/Calculator/Calculate.cshtml", model);
        }
        public IActionResult ShowData()
        {
            
            return View(context.calculators.ToList());
        }
    }
}
