using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Maps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.navigation = "Maps";
            ViewBag.area = "Maps";
            return View();
        }
    }
}