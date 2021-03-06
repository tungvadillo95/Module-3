﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogManagement.Models;
using BlogManagement.Services;
using BlogManagement.Models.ViewModels;
using BlogManagement.Models.Entity;

namespace BlogManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogService blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService blogService)
        {
            _logger = logger;
            this.blogService = blogService;
        }

        public IActionResult Index()
        {
            var blogs = new List<RegisterBlogView>();
            blogs = blogService.GetBlogs().ToList();
            return View(blogs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RegisterBlogView model)
        {
            if (ModelState.IsValid)
            {
                var blog = new Blog()
                {
                    BlogName = model.BlogName,
                    Present = model.Present,
                    Category=model.Category
                };
                if (blogService.CreateBlog(blog) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Lỗi hệ thống. Xin thử lại sau!");
            }
            var registerView = new RegisterBlogView();
            return View(registerView);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var blog = blogService.GetBlog(id);
            var blogEdit = new RegisterBlogView();
            if(blog != null)
            {
                blogEdit.Id = blog.BlogId;
                blogEdit.BlogName = blog.BlogName;
                blogEdit.Present = blog.Present;
                blogEdit.Category = blog.Category;
            }
            return View(blogEdit);
        }
        [HttpPost]
        public IActionResult Edit(RegisterBlogView model)
        {
            if (ModelState.IsValid)
            {
                if (blogService.UpdateBlog(model) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Lỗi hệ thống. Xin thử lại sau!");
            }
            var blogEdit = new RegisterBlogView();
            return View(blogEdit);
        }

        [Route("/Home/Delete/{blogId}")]
        public IActionResult DeleteStaff(int blogId)
        {
            var deleteResult = blogService.DeleteBlog(blogId);
            return Json(new { deleteResult });
        }
    }
}
