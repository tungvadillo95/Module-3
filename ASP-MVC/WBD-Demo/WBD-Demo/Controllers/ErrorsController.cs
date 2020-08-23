using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Controllers
{
    public class ErrorsController : Controller
    {
        [Route("Errors/{StatusCode}")]
        public ViewResult PageNotFound(int StatusCode)
        {
            ViewBag.ErrorMessage = $"Error {StatusCode}: Sorry the resource you requested could not be found";
            return View();
        }
        [Route("Error")]
        public ViewResult Error()
        {
            return View("Exception");
        }
    }
}
