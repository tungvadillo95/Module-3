using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Signup([Bind("Username,Password,Age,Email")] User model)
        {
            if (ModelState.IsValid)
            {
                TempData["Result"] = "Signup success";
            }
            else
            {
                TempData["Result"] = "Signup not success";
            }
            return View();
        }
    }
}
