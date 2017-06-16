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
        public IActionResult GeneralForms()
        {
            return View();
        }
    }
}