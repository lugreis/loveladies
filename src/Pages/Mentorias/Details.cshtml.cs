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
    public class DetailsModel : PageModel
    {
        private readonly MentoriasService _mentoraService;

        public DetailsModel(MentoriasService mentoraService)
        {
            _mentoraService = mentoraService;
        }

        public Mentoria Mentora { get; set; }

        public void OnGet(int id)
        {
            Mentora = _mentoraService.ObtemMentoriaPorId(id);
        }
    }
}
