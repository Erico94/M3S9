using M3S9_jogos.webApi.Domain.Enums;
using M3S9_jogos.webApi.Domain;

public class CreateJogoDTO
{
public string Nome { get; set; }
    public EcategoriaJogo Categoria { get; set; }
    public int EstudioId { get; set; }
    public Estudio Estudio { get; set; }
}
    
