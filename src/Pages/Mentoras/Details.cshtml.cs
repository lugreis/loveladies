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
    public class DetailsModel : PageModel
    {
        private readonly MentorasService _mentoraService;

        public DetailsModel(MentorasService mentoraService)
        {
            _mentoraService = mentoraService;
        }

        public Mentora Mentora { get; set; }

        public void OnGet(int id)
        {
            Mentora = _mentoraService.ObtemMentoraPorId(id);
        }
    }
}
