using System;
using Microsoft.AspNetCore.Mvc;
namespace SQLIjection.Controllers
{
    public class EntradaController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string usuario, string senha)
        {
            try
            {
                string stringConexao = "Database=Usuariodb;Data Source=localhost;User Id=root;";
                using (var conexao = new MySqlConnector.MySqlConnection(stringConexao))
                {
                    conexao.Open();
                    var consulta = "SELECT COUNT(*) FROM tabelausuarios WHERE usuario = '" + usuario + "' AND Senha = '" + senha + "'";
                    MySqlConnector.MySqlCommand myCommand = new MySqlConnector.MySqlCommand(consulta);
                    myCommand.Connection = conexao;
                    Int64 resultado = (Int64)myCommand.ExecuteScalar();
                    if (resultado > 0)
                        ViewBag.Mensagem = "Login efetuado com sucesso";
                    else
                        ViewBag.Mensagem = "Falha no login";
                    myCommand.Connection.Close();
                }
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = "Erro: " + e.Message;
            }
            return View();
        }
    }
}