using Docker.Example.App.Models;
using Docker.Example.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Docker.Example.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Cadastro();
            model.MensagemDeRetorno = "";
            return View(model);
        }

        [HttpPost]
        public ActionResult Subscribe(Cadastro model)
        {
            if (ModelState.IsValid)
            {
                new CadastroService().Salvar(model);
            }
            else
            {
                model.MensagemDeRetorno = "O model não é válido!";
            }

            return View("Index", model);
        }
    }
}