using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class HomeController : Controller
    {
        List<ProductModel> products = new List<ProductModel>();
        public IActionResult Index()
        {
            products.Add(new ProductModel()
            {
                ID = 1,
                Name = "IPhone 10",
                Price = 15000000,
                Manufacturing = "USA"
            });
            products.Add(new ProductModel()
            {
                ID = 2,
                Name = "Macbook 2020",
                Price = 25000000,
                Manufacturing = "USA"
            });
            products.Add(new ProductModel()
            {
                ID = 3,
                Name = "Apple Watch S5",
                Price = 5000000,
                Manufacturing = "USA"
            });
            ViewBag.products = products;
            return View();
        }
    }
}
