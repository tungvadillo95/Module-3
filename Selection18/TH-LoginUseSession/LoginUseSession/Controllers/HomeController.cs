using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginUseSession.Models;
using LoginUseSession.Models.Dal;
using Microsoft.AspNetCore.Http;

namespace LoginUseSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        public HomeController(DataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                return RedirectToAction("UserDashboard");
            }
            return View();
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
                        HttpContext.Session.SetString("UserID", dbUser.UserId);
                        HttpContext.Session.SetString("Username", dbUser.Username);
                        return RedirectToAction("UserDashboard");
                    }
                }
            }
            TempData["Message"] = "Invalid username or password";
            return RedirectToAction("Index");
        }
        public IActionResult UserDashboard()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewData["Username"] = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
