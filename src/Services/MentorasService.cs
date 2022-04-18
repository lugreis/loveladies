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

        public List<Mentora> ObtemMentora()
        {
            return _contexto.Mentoras.ToList();
        }

        public void AdicionaMentora(Mentora mentora)
        {
            _contexto.Mentoras.Add(mentora);
            _contexto.SaveChanges();
        }

    }
}
