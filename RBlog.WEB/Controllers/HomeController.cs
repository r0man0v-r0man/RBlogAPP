﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RBlog.Service.Interfaces;
using RBlog.WEB.Models;

namespace RBlog.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService postService;
        public HomeController(IPostService postService)
        {
            this.postService = postService;
        }
        public IActionResult Index()
        {
            postService.InsertPost(new DATA.Entities.Post(){ Title = "trtrtrtrt" , Description = "123"});
            ViewBag.Test1 = "test OK";
            return View();
        }
    }
}
