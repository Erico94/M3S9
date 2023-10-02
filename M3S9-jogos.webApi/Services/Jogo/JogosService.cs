using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Jogos;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Services.Jogo
{
    public class JogosService
    {
        readonly IJogoRepository _jogoRepository;
        readonly IMapper _mapper;

        public JogosService(IJogoRepository jogoRepository, IMapper mapper)
        {
            _jogoRepository = jogoRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
          
           _jogoRepository.Delete(id);
        }

        public IEnumerable<ViewJogoDTO> GetAllJogos()
        {
            var jogos = _jogoRepository.Get();
          
            return _mapper.Map<IEnumerable<ViewJogoDTO>>(jogos);
        }

        public List<ViewJogoDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ViewJogoDTO> Insert(CreateJogoDTO dto)
        {
            throw new NotImplementedException();
        }

        public UpdateJogoDTO Put(int id, UpdateJogoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
