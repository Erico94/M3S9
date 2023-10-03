using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Jogos;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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

        public ViewJogoDTO Get (int id)
        {
            var jogo = _jogoRepository.Get(id);
            return _mapper.Map<ViewJogoDTO>(jogo);
           
        }
//<ViewJogoDTO>
        public void Insert (CreateJogoDTO dto)
        {
           var jogo = _mapper.Map<CreateJogoDTO>(dto);
            _jogoRepository.Insert(jogo);
        }

        public void Update (int id, UpdateJogoDTO dto)
        {
            var jogo = _mapper.Map<UpdateJogoDTO>(dto);
            jogo.Id = id;
            _jogoRepository.Update(jogo);
        }
    }
}
