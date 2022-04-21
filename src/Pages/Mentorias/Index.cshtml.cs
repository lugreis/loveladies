using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loveladies.Pages.Mentorias
{
    public class IndexModel : PageModel
    {
        private readonly MentoriasService _mentorasService;

        public List<Mentoria> Mentorias { get; set; }

        [FromQuery(Name = "categoria")]
        public string Categoria { get; set; }

        public IndexModel(MentoriasService mentorasService)
        {
            _mentorasService = mentorasService;
        }

        public void OnGet()
        {
            Mentorias = _mentorasService.ObtemMentoriaPorCategoria(int.Parse(Categoria));
        }
    }
}
