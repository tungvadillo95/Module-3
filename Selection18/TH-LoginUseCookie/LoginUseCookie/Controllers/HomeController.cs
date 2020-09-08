using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginUseCookie.Models;

namespace LoginUseCookie.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        public HomeController(DataContext context)
        {
            _dataContext = context;
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                foreach (User dbUser in _dataContext.Users)
                {
                    if (user.Password == dbUser.Password && user.Username == dbUser.Username)
                    {
                        Response.Cookies.Append("username", dbUser.Username);
                        return RedirectToAction("UserDashboard");
                    }
                }
            }
            TempData["Message"] = "Invalid username or password";
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            if (Request.Cookies["username"] != null)
            {
                return RedirectToAction("UserDashboard");
            }
            return View();
        }
        public IActionResult UserDashboard()
        {
            if (Request.Cookies["username"] != null)
            {
                ViewData["username"] = Request.Cookies["username"];
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
