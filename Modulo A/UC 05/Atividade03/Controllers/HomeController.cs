using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade03.Models;

namespace Atividade03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos(){
            return View();
        }

        public IActionResult Agendamento(){
            return View();
        }

        [HttpPost]
        public IActionResult Agendamento(Agendamento dados){
            Dados.Inserir(dados);
            return View("Confirmacao");
        }

        public IActionResult Confirmacao(){
            Agendamento agendado = Dados.Listar();
            return View(agendado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
