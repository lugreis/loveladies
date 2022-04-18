using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loveladies.Pages.Mentoras
{
    public class CreateModel : PageModel
    {
        private readonly MentorasService _mentora;

        [BindProperty]
        public Mentora Mentora { get; set; }

        public CreateModel(MentorasService mentora)
        {
            _mentora = mentora;
        }

        public IActionResult OnPost()
        {
            _mentora.AdicionaMentora(Mentora);
            return RedirectToAction("Index");
        }
    }
}
