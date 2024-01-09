using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TestandoASPNETMVC.Controllers
{
    public class OlaMundoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(int id, string nome)
        {
            return HtmlEncoder.Default.Encode("Oi " + nome + " Id: " + id);
            //return "Estou no método welcome";
        }

        public IActionResult MostrarMensagem(string nome, int qtd)
        {
            ViewData["Nome"] = nome;
            ViewData["Qtd"] = qtd;

            return View();
        }
    }
}
