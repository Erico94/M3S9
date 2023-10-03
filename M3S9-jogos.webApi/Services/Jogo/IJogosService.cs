using M3S9_jogos.webApi.DTOs.Jogos;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Services.Jogo
{
    public interface IJogosService
    {
        List<ViewJogoDTO> Get();
        List<ViewJogoDTO> Get(int id);
        List<ViewJogoDTO> Insert (CreateJogoDTO dto);
        UpdateJogoDTO Put(int id, UpdateJogoDTO dto);
        void Delete(int id);
    }
}