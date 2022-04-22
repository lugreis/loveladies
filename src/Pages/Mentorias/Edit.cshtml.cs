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
    public class EditModel : PageModel
    {
        private readonly MentoriasService _mentoriaService;
        private readonly CategoriasService _categoriaService;
        private readonly UserManager<IdentityUser> _userManager;

        public EditModel(MentoriasService mentoriaService, CategoriasService categoriaService, UserManager<IdentityUser> userManager)
        {
            _mentoriaService = mentoriaService;
            _categoriaService = categoriaService;
            _userManager = userManager;
        }

        [BindProperty]
        public Mentoria Mentoria { get; set; }
        public SelectList Categorias { get; set; }

        public IActionResult OnPost()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            Mentoria.UserId = userId;
            
            _mentoriaService.EditaMentoria(Mentoria);
            return RedirectToPage("MinhasMentorias");
        }

        public void OnGet(int id)
        {
            Mentoria = _mentoriaService.ObtemMentoriaPorId(id);

            var categorias = _categoriaService.ObtemCategoria();
            Categorias = new SelectList(categorias, "Id", "Nome");
        }
    }
}
