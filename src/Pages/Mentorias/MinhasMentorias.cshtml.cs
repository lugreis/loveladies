using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loveladies.Pages.Mentorias
{
    public class MinhasMentoriasModel : PageModel
    {
        private readonly MentoriasService _mentoriaService;
        private readonly UserManager<IdentityUser> _userManager;

        public List<Mentoria> Mentorias { get; set; }
        public MinhasMentoriasModel(MentoriasService mentoriaService, UserManager<IdentityUser> userManager)
        {
            _mentoriaService = mentoriaService;
            _userManager = userManager;
        }

        public void OnGet()
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            Mentorias = _mentoriaService.ObtemMentoriasPorUserId(userId);
        }

        public IActionResult OnPostDelete(int id)
        {
            _mentoriaService.ExcluiMentoria(id);
            return RedirectToAction("MinhasMentorias");
        }
    }
}
