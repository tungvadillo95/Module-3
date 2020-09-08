using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationFormLogin.Models;

namespace ValidationFormLogin.Controllers
{
    public class UserController : Controller

    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login([Bind("Username,Password")] User user)
        {
            return View();
        }

    }
}
