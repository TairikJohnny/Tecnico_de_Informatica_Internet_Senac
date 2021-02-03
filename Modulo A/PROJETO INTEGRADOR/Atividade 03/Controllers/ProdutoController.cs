using Microsoft.AspNetCore.Mvc;

namespace Atividade03.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Cadastro()
        {

            // if (HttpContext.Session.GetInt32("IdUsuario") == null)
            // {
            //     return RedirectToAction("Login", "Usuario");
            // }

            // if (HttpContext.Session.GetString("Conta") == "usuario")
            // {
            //     return RedirectToAction("Login", "Usuario");
            // }

            return View();
        }

        // [HttpPost]
        // public IActionResult Cadastro(Pacote pacote)
        // {

        //     if (HttpContext.Session.GetInt32("IdUsuario") == null)
        //     {
        //         return RedirectToAction("Login", "Usuario");
        //     }

        //     PacoteBanco pacoteBanco = new PacoteBanco();
        //     pacoteBanco.Inserir(pacote);
        //     ViewBag.Mensagem = "Pacote cadastrado com sucesso!";
        //     return View();
        // }

        public IActionResult Lista()
        {

            // if (HttpContext.Session.GetInt32("IdUsuario") == null)
            // {
            //     return RedirectToAction("Login", "Usuario");
            // }

            // if (HttpContext.Session.GetString("Conta") == "usuario")
            // {
            //     return RedirectToAction("Login", "Usuario");
            // }

            // PacoteBanco pacoteBanco = new PacoteBanco();
            // List<Pacote> Lista = pacoteBanco.Listar();
            // return View(Lista);

            return View();
        }

        public IActionResult Editar(int IdPacotes)
        {

            // if (HttpContext.Session.GetInt32("IdUsuario") == null)
            // {
            //     return RedirectToAction("Login", "Usuario");
            // }

            // PacoteBanco pacoteBanco = new PacoteBanco();
            // Pacote pacote = pacoteBanco.BuscarPorId(IdPacotes);

            // return View(pacote);

            return View();
        }

        // [HttpPost]
        // public IActionResult Editar(Pacote pacote)
        // {

        //     if (HttpContext.Session.GetInt32("IdUsuario") == null)
        //     {
        //         return RedirectToAction("Login", "Usuario");
        //     }

        //     PacoteBanco pacoteBanco = new PacoteBanco();
        //     pacoteBanco.Atualizar(pacote);
        //     ViewBag.Mensagem = "Pacote Atualizado com sucesso!";
        //     return RedirectToAction("Lista");
        // }

        public IActionResult Remover(int IdProdutos)
        {
            // if (HttpContext.Session.GetInt32("IdUsuario") == null)
            // {
            //     return RedirectToAction("Login", "Usuario");
            // }

            // PacoteBanco pacoteBanco = new PacoteBanco();
            // pacoteBanco.Remover(IdPacotes);

            return RedirectToAction("Lista");
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Produtos()
        {  
            // if(HttpContext.Session.GetInt32("IdUsuario") == null)
            // return RedirectToAction("Login", "Usuario");
            
            // PacoteBanco ur = new PacoteBanco();
            // List<Pacote> pacotes = ur.Listar();
            // return View(pacotes);

            return View();
        }
    }
}