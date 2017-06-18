using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.UIELements.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.navigation = "Buttons";
            ViewBag.area = "UI ELements";
            return View();
        }

        public IActionResult Icons()
        {
            ViewBag.navigation = "Icons";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult Typography()
        {
            ViewBag.navigation = "Typography";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult AlertsAndNotifications()
        {
            ViewBag.navigation = "Alerts And Notifications";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult Modals()
        {
            ViewBag.navigation = "Modals";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult TabsAndAccordions()
        {
            ViewBag.navigation = "Tabs And Accordions";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult Sliders()
        {
            ViewBag.navigation = "Sliders";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult GraphsAndCharts()
        {
            ViewBag.navigation = "Graphs And Charts";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult PanelsAndWidgets()
        {
            ViewBag.navigation = "Panels And Widgets";
            ViewBag.area = "UI ELements";
            return View();
        }
        public IActionResult Extras()
        {
            ViewBag.navigation = "Extras";
            ViewBag.area = "UI ELements";
            return View();
        }
    }
}