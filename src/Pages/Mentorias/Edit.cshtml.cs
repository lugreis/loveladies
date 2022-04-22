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
    public class EditModel : PageModel
    {
        private readonly MentoriasService _mentoriaService;
        private readonly CategoriasService _categoriaService;

        public EditModel(MentoriasService mentoriaService, CategoriasService categoriaService)
        {
            _mentoriaService = mentoriaService;
            _categoriaService = categoriaService;
        }

        public Mentoria Mentoria { get; set; }
        public SelectList Categorias { get; set; }

        public void OnPost()
        {
            _mentoriaService.EditaMentoria(Mentoria);
        }

        public void OnGet()
        {
            var categorias = _categoriaService.ObtemCategoria();
            Categorias = new SelectList(categorias, "Id", "Nome");
        }
    }
}
