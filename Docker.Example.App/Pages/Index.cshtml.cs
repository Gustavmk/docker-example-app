using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Docker.Example.App.Pages
{
    public class IndexModel : PageModel
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public void OnGet()
        {

        }

    }
}
