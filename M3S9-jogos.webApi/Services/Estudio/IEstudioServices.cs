using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Estudios;

public interface IEstudioServices
{
    Estudio CreateEstudioDTO(CreateEstudioDTO estudioCreateDTO);
    bool DeleteEstudio(int id);
    IEnumerable<EstudioViewDTO> Get();
    EstudioViewDTO GetEstudioById(int id);
    Estudio UpdateEstudioDTO(int id, UpdateEstudioDTO updateEstudioDTO);
}