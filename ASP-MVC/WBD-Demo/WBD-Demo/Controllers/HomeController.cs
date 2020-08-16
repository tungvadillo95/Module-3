using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBD_Demo.Models;

namespace WBD_Demo.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        public HomeController()
        {
            employeeRepository = new EmployeeRespository();
        }
        public ViewResult Index()
        {
            ViewData["employees"] = employeeRepository.Gets();
            return View();
        }
    }
}
