using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogManagement.Models.Entity;
using BlogManagement.Models.ViewModels;
using BlogManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogManagement.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }
        public IActionResult Index(int blogId)
        {
            var blogs = new List<RegisterPostView>();
            blogs = postService.GetPosts(blogId).ToList();
            ViewBag["BlogID"] = blogId;
            return View(blogs);
        }
        [HttpGet]
        public IActionResult Create(int blogID)
        {
            var post = new RegisterPostView()
            {
                BlogId = blogID
            };
            return View(post);
        }
        [HttpPost]
        public IActionResult Create(RegisterPostView model)
        {
            if (ModelState.IsValid)
            {
                var post = new Post()
                {
                    Title = model.Title,
                    Content = model.Content,
                    DateUpload = DateTime.Now.ToString("dd/MM/yyyy-HH")
                };
                if (postService.CreatePost(post) > 0)
                {
                    return RedirectToAction("Index", "Post");
                }
                ModelState.AddModelError("", "Lỗi hệ thống. Xin thử lại sau!");
            }
            var registerView = new RegisterPostView();
            return View(registerView);
        }
    }
}
