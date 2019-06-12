using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docker.Example.App.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Docker.Example.App.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subscribe(IndexModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: SubscribeUser(model.Email);
            }

            return View("Index", model);
        }
    }
}