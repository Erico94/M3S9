using AutoMapper;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Services.Estudio
{
    public class EstudioServices : IEstudioService
    {
        readonly EstudioRepository estudioRepository;
        readonly IMapper mapper;

        public EstudioServices(EstudioRepository _estudioRepository, IMapper _mapper)
        {
            _estudioRepository = estudioRepository;
            _mapper = mapper;
        }

       

        public ActionResult<EstudioViewDTO> Get()
        {
            List<Estudio> estudios = _estudioRepository.Get();
            if (estudios == null || estudios.Count == 0)
            {
                return NoContent();
            }
            var listDto = _mapper.Map<List<EstudioViewDTO>>(estudios);
            return Ok(listDto);
        }

        public ActionResult<EstudioViewDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Post(CreateEstudioDTO dto)
        {
            throw new NotImplementedException();
        }

        public ActionResult Put(int id, UpdateEstudioDTO dto)
        {
            throw new NotImplementedException();
        } 
        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
