using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerManager.Models;
using CustomerManager.Services;
using CustomerManager.Models.ViewModels;
using CustomerManager.Models.Entity;

namespace CustomerManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService customerService;
        private const int defaultProvinceId = 15;
        public HomeController(ILogger<HomeController> logger, ICustomerService customerService)
        {
            _logger = logger;
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = new List<CustomerView>();
            customers = customerService.GetCustomers().ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterView();
            model.Provinces = customerService.GetProvinces();
            model.ProvinceId = defaultProvinceId;
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterView model)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer()
                {
                    Name = model.Name,
                    Address = model.Address,
                    Phone = model.Phone,
                    ProvinceId = model.ProvinceId
                };
                var customerId = customerService.CreateCustomer(customer);
                if (customerId > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Lỗi hệ thống.Xin thử lại sau!");
            }
            var registerView = new RegisterView();
            registerView.Provinces = customerService.GetProvinces();
            registerView.ProvinceId = defaultProvinceId;
            return View(registerView);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = customerService.GetCustomer(id);
            var customerEdit = new RegisterView();
            if (customer != null)
            {
                customerEdit.Name = customer.Name;
                customerEdit.Address = customer.Address;
                customerEdit.Phone = customer.Phone;
                customerEdit.ProvinceId = customer.ProvinceId;
                customerEdit.Provinces = customerService.GetProvinces();
            }
            return View(customerEdit);
        }
        [HttpPost]
        public IActionResult Edit(RegisterView model)
        {
            if (ModelState.IsValid)
            {
                if (customerService.UpdateCustomer(model) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Lỗi hệ thống.Xin thử lại sau!");
            }
            var registerView = new RegisterView();
            registerView.Provinces = customerService.GetProvinces();
            registerView.ProvinceId = defaultProvinceId;
            return View(registerView);
        }
        [Route("/Home/Delete/{customerId}")]
        public IActionResult DeleteStaff(int customerId)
        {
            var deleteResult = customerService.DeleteCustomer(customerId);
            return Json(new { deleteResult });
        }
    }
}
