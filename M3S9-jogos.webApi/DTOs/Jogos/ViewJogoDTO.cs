using M3S9_jogos.webApi.Domain.Enums;
using M3S9_jogos.webApi.Domain;

namespace M3S9_jogos.webApi.DTOs.Jogos
{
    public class ViewJogoDTO
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }
        public EcategoriaJogo Categoria { get; set; }
        public int EstudioId { get; set; }
        public Estudio Estudio { get; set; }

    }
}
