using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewExample.Models;

namespace ViewExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/ViewData")]
        public IActionResult ViewDataTest()
        {
            ViewData["Greeting"] = "This is View Data test page";
            ViewData["Book"] = new Book()
            {
                BookID = 1,
                BookName = "Clean code",
                Author = "Robert Martin"
            };
            return View();
        }

        [HttpGet("/ViewBag")]
        public IActionResult ViewBagTest()
        {
            ViewBag.Greeting = "This is View Bag test page";
            ViewBag.Book = new Book()
            {
                BookID = 2,
                BookName = "Lean thinking",
                Author = "James P. Womack"
            };
            return View();
        }

        [HttpGet("/ViewModel")]
        public IActionResult ViewModelTest()
        {
            Book book = new Book()
            {
                BookID = 3,
                BookName = "Universe in a nutshell",
                Author = "Stephen Hawking"
            };

            Location location = new Location()
            {
                Row = 2,
                Column = 4,
                Shelf = "A1"
            };

            BookDetailViewModel bookDetail = new BookDetailViewModel()
            {
                Book = book,
                BookLocation = location
            };

            return View(bookDetail);
        }
    }
}
