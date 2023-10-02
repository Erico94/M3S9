using M3S9_jogos.webApi.Domain.Enums;
using M3S9_jogos.webApi.Domain;
using System.ComponentModel.DataAnnotations;

public class CreateJogoDTO
{
    [Required]
    public string Nome { get; set; }
    [Required]
    public EcategoriaJogo Categoria { get; set; }
    [Required]
    public int EstudioId { get; set; }

}

