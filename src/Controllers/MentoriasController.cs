using loveladies.Models;
using loveladies.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace loveladies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentoriasController : ControllerBase
    {
        private readonly MentoriasService _mentoriasService;

        public MentoriasController(MentoriasService mentoriasService)
        {
            _mentoriasService = mentoriasService;
        }

        // GET: api/<MentoriasController>
        [HttpGet]
        public List<Mentoria> Get(int id)
        {
            return _mentoriasService.ObtemMentoriaPorCategoria(id);
        }
    }
}
