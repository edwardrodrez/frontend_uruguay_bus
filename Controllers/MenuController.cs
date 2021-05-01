using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UruguayBus.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Usuario()
        {
            return View();
        }
        public IActionResult Conductor()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult SuperAdmin()
        {
            return View();
        }
    }
}
