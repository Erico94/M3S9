using System.ComponentModel.DataAnnotations;

namespace M3S9_jogos.webApi.DTOs.Estudios
{
    public class CreateEstudioDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereço { get; set; }
       
    }
}
