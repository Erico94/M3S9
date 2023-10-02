namespace M3S9_jogos.webApi.Domain
{
    public class Estudio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public ICollection<Jogo> Jogos { get; set; }

    }
}
