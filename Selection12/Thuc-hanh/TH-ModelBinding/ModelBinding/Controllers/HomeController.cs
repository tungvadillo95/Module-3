using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        static List<Product> products = new List<Product>();
        public IActionResult Index(List<Product> model)
        {
            model = products;
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateAndUpdate(Product model)
        {
            if (ModelState.IsValid)
            {
                bool isUpdated = false;
                foreach (Product product in products)
                {
                    if (model.Name == product.Name)
                    {
                        product.Brand = model.Brand;
                        product.Description = model.Description;
                        TempData["StatusMessage"] = "Product " + model.Name + " is updated successfully";
                        isUpdated = true;
                        break;
                    }
                }

                if (!isUpdated)
                {
                    products.Add(model);
                    TempData["StatusMessage"] = "Product " + model.Name + " created successfully. There're " + products.Count + " products now.";
                }
            }
            else
            {
                TempData["StatusMessage"] = "Failed to create the product. Please try again";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
