using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MedicalDeclaration.Models;
using MedicalDeclaration.Service;
using MedicalDeclaration.Models.ViewModels;
using MedicalDeclaration.Models.Entity;

namespace MedicalDeclaration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMedicalDeclarationService medicalDeclarationService;

        public HomeController(ILogger<HomeController> logger,
                              IMedicalDeclarationService medicalDeclarationService)
        {
            _logger = logger;
            this.medicalDeclarationService = medicalDeclarationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //--------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult CreatePersonalInfo()
        {
            var model = new CreatePersonalInfomationView();
            model.Gates = medicalDeclarationService.GetGates();
            model.Genders = medicalDeclarationService.GetGenders();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreatePersonalInfo(CreatePersonalInfomationView model)
        {
            if (ModelState.IsValid)
            {
                var personalInfo = new PersonalInfomation()
                {
                    GateId = model.GateId,
                    PersonalName = model.PersonalName,
                    YearOfBirth = model.YearOfBirth,
                    GenderId = model.GenderId,
                    PassportNumber = model.PassportNumber
                };
                var personalInfoId = medicalDeclarationService.CreatePersonalInfo(personalInfo);
                if (personalInfoId > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Lỗi hệ thống. Xin thử lại sau!");
            }
            var createView = new CreatePersonalInfomationView();
            return View(createView);
        }


        //--------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult CreateTravelInfo()
        {
            var model = new CreateTravelInformationView();
            model.Provinces = medicalDeclarationService.GetProvinces();
            ViewBag.Vehicles = GetVehicles();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateTravelInfo(CreateTravelInformationView model)
        {
            if (ModelState.IsValid)
            {
                var newModel = medicalDeclarationService.CreateTravelInfo(model);
                return RedirectToAction("Index", "Home", new { ID = newModel.TravelInformationId });
            }
            return View();
        }
        private List<Vehicle> GetVehicles()
        {
            return medicalDeclarationService.GetVehicles().ToList();
        }

        //--------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult CreateContactAddress()
        {
            var model = new CreateContactAddressView();
            model.Provinces = medicalDeclarationService.GetProvinces();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateContactAddress(CreateTravelInformationView model)
        {
            if (ModelState.IsValid)
            {
                var newModel = medicalDeclarationService.CreateTravelInfo(model);
                return RedirectToAction("Index", "Home", new { ID = newModel.TravelInformationId });
            }
            return View();
        }
        [Route("/Home/Districts/{provinceId}")]
        public IActionResult GetDistricts(int provinceId)
        {
            var districts = medicalDeclarationService.GetDistricts(provinceId);
            return Json(new { districts });
        }

        [Route("/Home/Wards/{districtId}/{provinceId}")]
        public IActionResult GetWards(int districtId, int provinceId)
        {
            var wards = medicalDeclarationService.GetWards(districtId, provinceId);
            return Json(new { wards });
        }
    }
}
