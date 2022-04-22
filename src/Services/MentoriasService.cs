using loveladies.Data;
using loveladies.Models;
using System.Collections.Generic;
using System.Linq;

namespace loveladies.Services
{
    public class MentoriasService
    {
        private readonly ApplicationDbContext _contexto;

        public MentoriasService(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public List<Mentoria> ObtemMentoria()
        {
            return _contexto.Mentorias.ToList();
        }

        public List<Mentoria> ObtemMentoriaPorCategoria(int categoriaId)
        {
            return _contexto.Mentorias.Where(x => x.CategoriaId == categoriaId && x.Ativo == true).ToList();
        }

        public Mentoria ObtemMentoriaPorId(int id)
        {
            return _contexto.Mentorias.First(x => x.Id == id);
        }

        public List<Mentoria> ObtemMentoriasPorUserId(string userId)
        {
            return _contexto.Mentorias.Where(x => x.UserId == userId).ToList();
        }

        public void AdicionaMentoria(Mentoria mentoria)
        {
            _contexto.Mentorias.Add(mentoria);
            _contexto.SaveChanges();
        }

        public void EditaMentoria(Mentoria mentoria)
        {
            _contexto.Mentorias.Update(mentoria);
            _contexto.SaveChanges();
        }

        public void ExcluiMentoria(int id)
        {
            var mentoria = ObtemMentoriaPorId(id);
            _contexto.Mentorias.Remove(mentoria);
            _contexto.SaveChanges();
        }

    }
}
