using System.ComponentModel.DataAnnotations;

namespace M3S9_jogos.webApi.DTOs.Estudios
{
    public class UpdateEstudioDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereço { get; set; }
        public DateTime DataCriacao { get; set; }

    }

}