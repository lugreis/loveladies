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
    public class IndexModel : PageModel
    {
        private readonly MentorasService _mentorasService;

        public List<Mentoria> Mentoras { get; set; }

        [FromQuery(Name = "categoria")]
        public string Categoria { get; set; }

        public IndexModel(MentorasService mentorasService)
        {
            _mentorasService = mentorasService;
        }

        public void OnGet()
        {
            Mentoras = _mentorasService.ObtemMentoraPorCategoria(int.Parse(Categoria));
        }
    }
}
