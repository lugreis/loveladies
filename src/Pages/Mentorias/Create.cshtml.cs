using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace loveladies.Pages.Mentorias
{
    public class CreateModel : PageModel
    {
        private readonly MentoriasService _mentoraService;
        private readonly CategoriasService _categoriaService;

        [BindProperty]
        public Mentoria Mentora { get; set; }
        public SelectList Categorias { get; set; }

        public CreateModel(MentoriasService mentoraService, CategoriasService categoriaService)
        {
            _mentoraService = mentoraService;
            _categoriaService = categoriaService;
        }

        public IActionResult OnPost()
        {
            _mentoraService.AdicionaMentoria(Mentora);
            return RedirectToAction("Index");
        }

        public void OnGet()
        {
            var categorias = _categoriaService.ObtemCategoria();
            Categorias = new SelectList(categorias, "Id", "Nome");
        }
    }
}
