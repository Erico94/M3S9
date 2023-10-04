using M3S9_jogos.webApi.DTOs.Jogos;

namespace M3S9_jogos.webApi.Services.Jogo
{
    public interface IJogosService
    {
        Domain.Jogo CreateJogoDTO(CreateJogoDTO dto);
        bool Delete(int id);
        ViewJogoDTO Get(int id);
        IEnumerable<ViewJogoDTO> GetAllJogos();
        Domain.Jogo UpdateJogoDTO(int id, UpdateJogoDTO dto);
    }
}