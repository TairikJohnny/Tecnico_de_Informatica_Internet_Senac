using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AJAX.Models;

namespace AJAX.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string DataHora()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        [HttpPost]
        public string Login(string login, string senha)
        {
            if (login == "abc" && senha == "123")
                return "OK";
            else
                return "FALHA";
        }
    }
}
