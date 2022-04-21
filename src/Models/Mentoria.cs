using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace loveladies.Models
{
    public class Mentoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [DisplayName("Rede Social")]
        public string RedeSocial { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public IdentityUser User { get; set; }
        public int UserId { get; set; }

        public Mentoria()
        {

        }

        public Mentoria(string nome)
        {
            Nome = nome;
        }
    }
}
