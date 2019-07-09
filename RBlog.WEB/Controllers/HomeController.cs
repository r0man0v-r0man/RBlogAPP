using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RBlog.DATA.Entities;
using RBlog.Service.Interfaces;
using RBlog.WEB.Models;

namespace RBlog.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService postService;
        private readonly UserManager<User> userManager;
        public HomeController(IPostService postService, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.postService = postService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await userManager.CreateAsync(new DATA.Entities.User { UserName = "user1" });
            if (result.Succeeded)
            {
                var user = await userManager.FindByNameAsync("user1");
                postService.InsertPost(new Post { Title = "post1", User = user });
                ViewBag.Yes = "ok";
            }
            return View();
        }
    }
}
