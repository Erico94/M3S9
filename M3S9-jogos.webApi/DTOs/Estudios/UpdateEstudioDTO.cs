using System.ComponentModel.DataAnnotations;

namespace M3S9_jogos.webApi.DTOs.Estudios
{
    public class UpdateEstudioDTO
    {
        
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
        public DateTime DataCriacao { get; set; }

    }

}