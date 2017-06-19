using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.BugTracker.Controllers
{
    [Area("BugTracker")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.navigation = "Summary";
            ViewBag.area = "BugTracker";
            return View();
        }

        public IActionResult Issues()
        {
            ViewBag.navigation = "General Forms";
            ViewBag.area = "BugTracker";
            return View();
        }

        public IActionResult ViewIssue()
        {
            ViewBag.navigation = "View Issue";
            ViewBag.area = "BugTracker";
            return View();
        }
    }
}