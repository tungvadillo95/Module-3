using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        static List<Student> students = new List<Student>();
        public IActionResult Index(List<Student> model)
        {
            model = students;
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateAndUpdate(Student model)
        {
            if (ModelState.IsValid)
            {
                bool isUpdated = false;
                foreach (Student student in students)
                {
                    if (model.StudentID == student.StudentID)
                    {
                        student.Name = model.Name;
                        student.Classroom = model.Classroom;
                        student.Course = model.Course;
                        TempData["StatusMessage"] = "Student " + model.Name + " is updated successfully";
                        isUpdated = true;
                        break;
                    }
                }

                if (!isUpdated)
                {
                    students.Add(model);
                    TempData["StatusMessage"] = "Student " + model.Name + " created successfully. There're " + students.Count + " students now.";
                }
            }
            else
            {
                TempData["StatusMessage"] = "Failed to create the student. Please try again";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
