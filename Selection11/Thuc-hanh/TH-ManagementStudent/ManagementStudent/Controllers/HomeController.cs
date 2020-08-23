using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ManagementStudent.Models;

namespace ManagementStudent.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>();
        public IActionResult Index()
        {
            students.Add(new Student() { Id = 1, Name = "Phương", Address = "Hà Nội", Age = 20 });

            students.Add(new Student() { Id = 2, Name = "Tùng", Address = "Hà Nội", Age = 25 });

            students.Add(new Student() { Id = 3, Name = "Thế", Address = "Hà Nội", Age = 18 });

            students.Add(new Student() { Id = 4, Name = "Ngọc", Address = "Hà Nội", Age = 28 });

            ViewBag.students = students;

            return View();

        }
    }
}
