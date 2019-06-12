using Docker.Example.App.Models;
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
            }

            model.MensagemDeRetorno = "PARABENS";
            return View("Index", model);
        }
    }
}