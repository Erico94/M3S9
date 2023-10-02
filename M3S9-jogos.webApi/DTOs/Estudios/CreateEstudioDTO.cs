using System.ComponentModel.DataAnnotations;

namespace M3S9_jogos.webApi.DTOs.Estudios
{
    public class CreateJogoDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereço { get; set; }
       
    }
}
