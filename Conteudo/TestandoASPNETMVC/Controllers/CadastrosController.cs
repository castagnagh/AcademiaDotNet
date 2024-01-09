using Microsoft.AspNetCore.Mvc;
using TestandoASPNETMVC.Models;

namespace TestandoASPNETMVC.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(Pessoa p)
        {
            aulaentityContext contexto = new aulaentityContext();
            contexto.Pessoas.Add(p);
            contexto.SaveChanges();

            return View(p);
        }

        public IActionResult Consultar()
        {
            aulaentityContext contexto = new aulaentityContext();
            List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p).ToList();

            return View(pessoas);
        }
    }
}
