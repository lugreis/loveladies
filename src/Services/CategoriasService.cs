using loveladies.Data;
using loveladies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loveladies.Services
{
    public class CategoriasService
    {
        private readonly ApplicationDbContext _contexto;

        public CategoriasService(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public List<Categoria> ObtemCategoria()
        {
            return _contexto.Categorias.ToList();
        }
    }
}
