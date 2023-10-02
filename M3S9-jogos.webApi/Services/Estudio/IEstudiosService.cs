using M3S9_jogos.webApi.DTOs.Estudios;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Services.Estudio
{
    public interface IEstudiosService
    {
        ActionResult Delete(int id);
        ActionResult<EstudioViewDTO> Get();
        ActionResult<EstudioViewDTO> Get(int id);
        ActionResult Post(CreateEstudioDTO dto);
        ActionResult Put(int id, UpdateEstudioDTO dto);
    }
}