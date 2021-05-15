using System.Collections.Generic;
using Atividade04.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atividade04.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Cadastro()
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Produto produto)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            ProdutoBanco produtoBanco = new ProdutoBanco();
            produtoBanco.Inserir(produto);
            ViewBag.Mensagem = "Produto cadastrado com sucesso!";
            return View();
        }

        public IActionResult Lista()
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            ProdutoBanco produtoBanco = new ProdutoBanco();
            List<Produto> Lista = produtoBanco.Listar();
            return View(Lista);
        }

        public IActionResult Editar(int IdProduto)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            ProdutoBanco produtoBanco = new ProdutoBanco();
            Produto produto = produtoBanco.BuscarPorId(IdProduto);

            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            ProdutoBanco produtoBanco = new ProdutoBanco();
            produtoBanco.Atualizar(produto);
            ViewBag.Mensagem = "Pacote Atualizado com sucesso!";
            return RedirectToAction("Lista");
        }

        public IActionResult Remover(int IdProduto)
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            ProdutoBanco produtoBanco = new ProdutoBanco();
            produtoBanco.Remover(IdProduto);

            return RedirectToAction("Lista");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Produtos()
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login", "Usuario");

            ProdutoBanco ur = new ProdutoBanco();
            List<Produto> produtos = ur.Listar();
            return View(produtos);
        }
    }
}