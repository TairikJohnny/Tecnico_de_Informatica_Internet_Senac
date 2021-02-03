using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasAluno.Models;

namespace NotasAluno.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Detalhe()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Fulano de Tal";
            aluno.Idade = 15;
            aluno.Disciplina = "Ciências";
            aluno.Nota = 9.5;
            return View(aluno);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Aluno aluno)
        {
            BaseDados.Incluir(aluno);
            return View("Concluido");
        }

        public IActionResult Listagem()
        {
            List<Aluno> alunos = BaseDados.Listar();
            return View(alunos);
        }
    }
}
