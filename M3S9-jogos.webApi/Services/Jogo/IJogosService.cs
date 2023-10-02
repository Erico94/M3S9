using M3S9_jogos.webApi.DTOs.Jogos;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Services.Jogo
{
    public interface IJogosController
    {
        ActionResult Delete(int id);
        ActionResult<ViewJogoDTO> Get();
        ActionResult<ViewJogoDTO> Get(int id);
        ActionResult<ViewJogoDTO> Post(CreateJogoDTO dto);
        ActionResult Put(int id, UpdateJogoDTO dto);
    }
}