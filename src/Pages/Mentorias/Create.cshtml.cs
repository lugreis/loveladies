using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace loveladies.Pages.Mentorias
{
    public class CreateModel : PageModel
    {
        private readonly MentoriasService _mentoriaService;
        private readonly CategoriasService _categoriaService;
        private readonly UserManager<IdentityUser> _userManager;

        [BindProperty]
        public Mentoria Mentoria { get; set; }
        public SelectList Categorias { get; set; }

        public CreateModel(MentoriasService mentoraService, CategoriasService categoriaService, UserManager<IdentityUser> userManager)
        {
            _mentoriaService = mentoraService;
            _categoriaService = categoriaService;
            _userManager = userManager;
        }

        public IActionResult OnPost()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            Mentoria.UserId = userId;

            _mentoriaService.AdicionaMentoria(Mentoria);
            return RedirectToPage("MinhasMentorias");
        }

        public void OnGet()
        {
            var categorias = _categoriaService.ObtemCategoria();
            Categorias = new SelectList(categorias, "Id", "Nome");
        }
    }
}
