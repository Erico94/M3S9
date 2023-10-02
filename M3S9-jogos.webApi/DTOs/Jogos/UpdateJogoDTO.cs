using M3S9_jogos.webApi.Domain.Enums;
using M3S9_jogos.webApi.Domain;

public class UpdateJogoDTO
{
    public string Nome { get; set; }
    public EcategoriaJogo Categoria { get; set; }
    public int EstudioId { get; set; }
   
}