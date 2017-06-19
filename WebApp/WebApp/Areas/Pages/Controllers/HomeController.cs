using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.navigation = "Calendar";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult MediaManager()
        {
            ViewBag.navigation = "Media Manager";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult Timeline()
        {
            ViewBag.navigation = "Timeline";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult BlogList()
        {
            ViewBag.navigation = "Blog List";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult BlogSingle()
        {
            ViewBag.navigation = "Blog Single";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult PeopleDirectory()
        {
            ViewBag.navigation = "People Directory";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult Profile()
        {
            ViewBag.navigation = "Profile";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult Invoice()
        {
            ViewBag.navigation = "Invoice";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult SearchResults()
        {
            ViewBag.navigation = "Search Results";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult BlankPage()
        {
            ViewBag.navigation = "Blank Page";
            ViewBag.area = "Pages";
            return View();
        }

        public IActionResult NotFoundPage()
        {

            return View();
        }

        public IActionResult LockedPage()
        {

            return View();
        }

        public IActionResult SignIn()
        {

            return View();
        }

        public IActionResult SignUp()
        {

            return View();
        }
    }
}