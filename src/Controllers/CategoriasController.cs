using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace loveladies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly CategoriasService _categoriasService;

        public CategoriasController(CategoriasService categoriasService)
        {
            _categoriasService = categoriasService;
        }

        // GET: api/<CategoriasController>
        [HttpGet]
        public List<Categoria> Get()
        {
            return _categoriasService.ObtemCategoria();
        }       
    }
}
