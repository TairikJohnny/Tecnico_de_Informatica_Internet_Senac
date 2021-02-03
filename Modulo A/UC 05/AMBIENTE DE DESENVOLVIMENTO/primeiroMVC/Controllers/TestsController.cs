using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using primeiroMVC.Models;

namespace primeiroMVC.Controllers
{
   public class TestsController : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult Welcome(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}