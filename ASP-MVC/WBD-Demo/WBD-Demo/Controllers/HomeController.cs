using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WBD_Demo.Models;
using WBD_Demo.ViewModels;

namespace WBD_Demo.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IDepartmentRepository departmentRepository;
        private readonly ILanguageRepository languageRepository;

        //public HomeController()
        //{
        //    employeeRepository = new EmployeeRespository();
        //}
        public HomeController(IEmployeeRepository employeeRepository,
                               IWebHostEnvironment webHostEnvironment,
                               IDepartmentRepository departmentRepository,
                               ILanguageRepository languageRepository)
        {
            this.employeeRepository = employeeRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.departmentRepository = departmentRepository;
            this.languageRepository = languageRepository;
        }
        //[Route("~/")]
        //[Route("Home")]
        //[Route("Home/Index")]
        [AllowAnonymous]
        public ViewResult Index()
        {
            //ViewData["employees"] = employeeRepository.Gets();

            //ViewBag.Employees = employeeRepository.Gets();

            var employees = employeeRepository.Gets();
            return View(employees);
        }
        public ViewResult Details(int? ID)
        {
            //ViewBag.Employee = employeeRepository.Get(ID);

            //var employe = employeeRepository.Get(ID);
            //ViewBag.TitleName = "Liverpool Detail";
            //return View(employe);

            try
            {
                var employee = employeeRepository.Get(ID.Value);
                if (employee == null)
                {
                    //ViewBag.ErrorID = ID;
                    return View("~/Views/Errors/EmployeeNotFound.cshtml", ID.Value);
                }
                var detailViewModel = new HomeDetailViewModel()
                {
                    Employee = employeeRepository.Get(ID ?? 1),
                    TitleName = "Employee Detail"
                };
                return View(detailViewModel);
            }
           catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Departments = GetDepartments();
            ViewBag.Languages = GetLanguages();
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new CreateEmployeeViewModel()
                {
                    Name = model.Name,
                    Email = model.Email,
                    DepartmentId = model.DepartmentId,
                    Languages = model.Languages
                };
                string fileName = null;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using(var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                employee.Avatarpath = fileName;
                var newEmployee = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { ID = newEmployee.EmployeeId });
            }
            return View();
        }
        public ViewResult Edit(int ID)
        {
            var employee = employeeRepository.Get(ID);
            if (employee == null)
            {
                //ViewBag.ErrorID = ID;
                return View("~/Views/Errors/EmployeeNotFound.cshtml", ID);
            }
            var employeeEdit = new HomeEditViewModel()
            {
                AvatarPath = employee.Avatarpath,
                Name = employee.Name,
                Email = employee.Email,
                DepartmentId = employee.DepartmentId,
                ID = employee.ID,
                SelectedLanguages = employee.Languages
            };
            ViewBag.Departments = GetDepartments();
            ViewBag.Languages = GetLanguages();
            return View(employeeEdit);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new EditEmployeeViewModel()
                {
                    Name = model.Name,
                    Email = model.Email,
                    DepartmentId = model.DepartmentId,
                    EmployeeId = model.ID,
                    Avatarpath = model.AvatarPath,
                    Languages = model.Languages
                };
                string fileName = null;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    employee.Avatarpath = fileName;
                    if (!string.IsNullOrEmpty(model.AvatarPath) && (model.AvatarPath != "none-avatar.png"))
                        {
                            string delFile = Path.Combine(webHostEnvironment.WebRootPath
                                                , "images", model.AvatarPath);
                            System.IO.File.Delete(delFile);
                        }
                }
                var editEmployee = employeeRepository.Edit(employee);
                if (editEmployee != null)
                {
                    return RedirectToAction("Details", new { ID = employee.EmployeeId });
                }
            }
            return View();
        }
        public IActionResult Delete(int ID)
        {
            if (employeeRepository.Delete(ID))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        private List<Department> GetDepartments()
        {
            return departmentRepository.Gets().ToList();
        }
        private List<Language> GetLanguages()
        {
            return languageRepository.Gets().ToList();
        }
    }
}
