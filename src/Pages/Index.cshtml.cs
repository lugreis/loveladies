using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loveladies.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CategoriasService _categoriasService;

        public List<Categoria> Categorias { get; set; }

        public IndexModel(CategoriasService categoriasService)
        {          
            _categoriasService = categoriasService;
        }

        public void OnGet()
        {
            Categorias = _categoriasService.ObtemCategoria();
        }
    }
}
