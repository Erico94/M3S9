using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.Repositores;
using M3S9_jogos.webApi.Services.Estudio;

public class EstudioServices : IEstudioServices
{
    readonly IRepository<Estudio> _repository;
    readonly IMapper _mapper;

    public EstudioServices(IRepository<Estudio> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public IEnumerable<EstudioViewDTO> Get()
    {
        var estudios = _repository.GetAll();
        var estudiosDTO = _mapper.Map<IEnumerable<EstudioViewDTO>>(estudios);
        return estudiosDTO;
    }

    public EstudioViewDTO GetEstudioById(int id)
    {
        var estudio = _repository.GetById(id);
        var estudioDTO = _mapper.Map<EstudioViewDTO>(estudio);
        return estudioDTO;
    }

    public Estudio CreateEstudioDTO(CreateEstudioDTO estudioCreateDTO)
    {
        var estudio = _mapper.Map<Estudio>(estudioCreateDTO);
        var estudioCreated = _repository.Create(estudio);
        var estudioCreatedDTO = _mapper.Map<Estudio>(estudioCreated);
        return estudioCreatedDTO;
    }

    public Estudio UpdateEstudioDTO(int id, UpdateEstudioDTO updateEstudioDTO)
    {
        var estudio = _repository.GetById(id);
        if (estudio == null)
        {
            throw new Exception("Estúdio não encontrado");
        }
        _mapper.Map(updateEstudioDTO, estudio);

        var estudioUpdated = _repository.Update(estudio);
        var estudioUpdateDTO = _mapper.Map<Estudio>(estudioUpdated);
        return estudioUpdateDTO;
    }

    public bool DeleteEstudio(int id)
    {
        return _repository.Delete(id);
    }
}
