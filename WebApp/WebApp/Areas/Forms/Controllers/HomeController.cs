using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Forms.Controllers
{
    [Area("Forms")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.navigation = "General Forms";
            ViewBag.area = "Forms";
            return View();
        }

        public IActionResult FormLayouts()
        {
            ViewBag.navigation = "Form Layouts";
            ViewBag.area = "Forms";
            return View();
        }

        public IActionResult FormValidation()
        {
            ViewBag.navigation = "Form Validation";
            ViewBag.area = "Forms";
            return View();
        }

        public IActionResult FormWizards()
        {
            ViewBag.navigation = "Form Wizards";
            ViewBag.area = "Forms";
            return View();
        }

        public IActionResult WYSIWYG()
        {
            ViewBag.navigation = "WYSIWYG";
            ViewBag.area = "Forms";
            return View();
        }

        public IActionResult CodeEditor()
        {
            ViewBag.navigation = "Code Editor";
            ViewBag.area = "Forms";
            return View();
        }

        public IActionResult X_Editable()
        {
            ViewBag.navigation = "X-Editable";
            ViewBag.area = "Forms";
            return View();
        }
    }
}