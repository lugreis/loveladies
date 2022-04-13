namespace loveladies.Models
{
    public class Mentora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string RedeSocial { get; set; }
        public Categoria Categoria { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
