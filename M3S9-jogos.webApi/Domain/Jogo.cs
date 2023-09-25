using M3S9_jogos.webApi.Domain.Enums;

namespace M3S9_jogos.webApi.Domain
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EcategoriaJogo Categoria { get; set; }
        public int EstudioId { get; set; }
        public Estudio Estudio { get; set; }
    }
}
