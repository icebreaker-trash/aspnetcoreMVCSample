﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.navigation = "Dashboard";
            return View();
        }

        public IActionResult Email()
        {

            ViewBag.navigation = nameof(Email);
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
