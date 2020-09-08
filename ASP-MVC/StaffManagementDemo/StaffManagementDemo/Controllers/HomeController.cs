﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StaffManagementDemo.Models;
using StaffManagementDemo.Models.Entity;
using StaffManagementDemo.Models.ViewModels;
using StaffManagementDemo.Services;

namespace StaffManagementDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStaffService staffService;
        private const int defaultProvinceId = 15;
        private const int defaultDistrictId = 194;

        public HomeController(ILogger<HomeController> logger, IStaffService staffService)
        {
            _logger = logger;
            this.staffService = staffService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(CollectData());
        }

        private RegisterView CollectData()
        {
            var model = new RegisterView();
            model.Provinces = staffService.GetProvinces();
            model.ProvinceId = defaultProvinceId;
            model.Districts = staffService.GetDistricts(defaultProvinceId);
            model.DistrictId = defaultDistrictId;
            model.Wards = staffService.GetWards(model.DistrictId, model.ProvinceId);
            return model;
        }

        [HttpPost]
        public IActionResult Create(RegisterStaff model)
        {
            if (ModelState.IsValid)
            {
                var staff = new Staff()
                {
                    Address = model.Address,
                    DistrictId = model.DistrictId,
                    Email = model.Email,
                    Fullname = model.Fullname,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber,
                    ProvinceId = model.ProvinceId,
                    WardId = model.WardId
                };
                var staffId = staffService.CreateStaff(staff);
                if (staffId > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "System error, please try again later!");
            }
            var registerView = new RegisterView();
            return View(registerView);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(CollectData());
        }
        [HttpPost]
        public IActionResult Register(RegisterStaff model)
        {
            if (ModelState.IsValid)
            {
                var staff = new Staff()
                {
                    Address = model.Address,
                    DistrictId = model.DistrictId,
                    Email = model.Email,
                    Fullname = model.Fullname,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber,
                    ProvinceId = model.ProvinceId,
                    WardId = model.WardId
                };
                if (staffService.CreateStaff(staff) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "System error, please try again later!");
            }
            var registerView = new RegisterView();
            return View(registerView);
        }

        [Route("/Home/Districts/{provinceId}")]
        public IActionResult GetDistricts(int provinceId)
        {
            var districts = staffService.GetDistricts(provinceId);
            return Json(new { districts });
        }

        [Route("/Home/Wards/{districtId}/{provinceId}")]
        public IActionResult GetWards(int districtId, int provinceId)
        {
            var wards = staffService.GetWards(districtId, provinceId);
            return Json(new { wards });
        }
    }
}
