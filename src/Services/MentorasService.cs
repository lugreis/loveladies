using loveladies.Data;
using loveladies.Models;
using System.Collections.Generic;
using System.Linq;

namespace loveladies.Services
{
    public class MentorasService
    {
        private readonly ApplicationDbContext _contexto;

        public MentorasService(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public List<Mentoria> ObtemMentora()
        {
            return _contexto.Mentorias.ToList();
        }

        public List<Mentoria> ObtemMentoraPorCategoria(int categoriaId)
        {
            return _contexto.Mentorias.Where(x => x.CategoriaId == categoriaId).ToList();
        }

        public Mentoria ObtemMentoraPorId(int id)
        {
            return _contexto.Mentorias.First(x => x.Id == id);
        }

        public void AdicionaMentora(Mentoria mentora)
        {
            _contexto.Mentorias.Add(mentora);
            _contexto.SaveChanges();
        }

    }
}
