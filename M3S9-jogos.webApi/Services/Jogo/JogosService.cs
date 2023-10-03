using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Jogos;
using M3S9_jogos.webApi.Repositores;


namespace M3S9_jogos.webApi.Services.Jogo
{
    public class JogosService : IJogosService
    {
        readonly IRepository<M3S9_jogos.webApi.Domain.Jogo> _repository;
        readonly IMapper _mapper;

        public JogosService(IRepository<M3S9_jogos.webApi.Domain.Jogo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {

            return _repository.Delete(id);
        }

        public IEnumerable<ViewJogoDTO> GetAllJogos()
        {
            var jogos = _repository.GetAll();

            return _mapper.Map<IEnumerable<ViewJogoDTO>>(jogos);
        }

        public ViewJogoDTO Get(int id)
        {
            var jogo = _repository.GetById(id);
            return _mapper.Map<ViewJogoDTO>(jogo);

        }

        public M3S9_jogos.webApi.Domain.Jogo CreateJogoDTO(CreateJogoDTO dto)
        {
            var jogo = _mapper.Map<M3S9_jogos.webApi.Domain.Jogo>(dto);
            var jogoCreated = _repository.Create(jogo);
            var jogoCreatedDTO = _mapper.Map<M3S9_jogos.webApi.Domain.Jogo>(jogoCreated);
            return jogoCreatedDTO;
        }

        public M3S9_jogos.webApi.Domain.Jogo UpdateJogoDTO(int id, UpdateJogoDTO dto)
        {
            var jogo = _repository.GetById(id);
            if (jogo == null)
                throw new Exception("Jogo não encontrado");
            _mapper.Map(dto, jogo);

            var jogoUpdated = _repository.Update(jogo);
            var jogoUpdatedDTO = _mapper.Map<M3S9_jogos.webApi.Domain.Jogo>(jogoUpdated);
            return jogoUpdatedDTO;

        }
    }
}
