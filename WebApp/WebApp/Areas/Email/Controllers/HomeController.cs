using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Email.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.navigation = "Email";
            ViewBag.area = "Email";
            return View();
        }

        public IActionResult ReadEmail()
        {
            ViewBag.navigation = "Read Email";
            ViewBag.area = "Email";
            return View();
        }

        public IActionResult ComposeEmail()
        {
            ViewBag.navigation = "Compose Email";
            ViewBag.area = "Email";
            return View();
        }
    }
}