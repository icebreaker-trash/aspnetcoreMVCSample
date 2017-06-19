using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.SkinsAndLayouts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.navigation = "Skins & Layouts";
            ViewBag.area = "SkinsAndLayouts";
            return View();
        }

        public IActionResult HorizontalMenu()
        {
            ViewBag.navigation = "Horizontal Menu";
            ViewBag.area = "SkinsAndLayouts";
            return View();
        }

        public IActionResult HorizontalMenuWithSideBar()
        {
            ViewBag.navigation = "Horizontal Menu";
            ViewBag.area = "SkinsAndLayouts";
            return View();
        }

        public IActionResult FixedWidth()
        {
            ViewBag.navigation = "Fixed Width";
            ViewBag.area = "SkinsAndLayouts";
            return View();
        }

        public IActionResult NewFixedWidth()
        {
            ViewBag.navigation = "Fixed Width";
            ViewBag.area = "SkinsAndLayouts";
            return View();
        }
    }
}