using CSModelValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSModelValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Signup(User model)
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
