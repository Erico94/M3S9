using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        readonly EstudioRepository _estudioRepository;
        readonly IMapper _mapper;
        public EstudiosController(EstudioRepository estudioRepository, IMapper mapper)
        {
            _estudioRepository = estudioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<EstudioViewDTO> Get()
        {
            List<Estudio> estudios = _estudioRepository.Get();
            if (estudios == null || estudios.Count == 0)
            {
                return NoContent();
            }
            var listDto =_mapper.Map<List<EstudioViewDTO>>(estudios);
            return Ok(listDto);
        }
        [HttpGet("{id}")]
        public ActionResult<EstudioViewDTO> Get(int id)
        {
            Estudio estudio = _estudioRepository.Get(id);
            if (estudio == null)
            {
                return NotFound();
            }
            var dto =_mapper.
                Map<EstudioViewDTO>(estudio);
           
            return Ok(dto);
        }

        [HttpPost]
        public ActionResult Post(CreateEstudioDTO dto)
        {
            var estudio = _mapper.Map<Estudio>(dto);
            _estudioRepository.Insert(estudio);

            //var estudioViewDto = _mapper.Map<EstudioViewDTO>(estudio);

            return Ok(estudio);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, UpdateEstudioDTO dto)
        {
            if (_estudioRepository.Get(id) == null)
                return NotFound();

            var estudio = _mapper.Map<Estudio>(dto);
            if (estudio.Id != id)
                return BadRequest();

            _estudioRepository.Update(estudio);

            return NoContent();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var estudio = _estudioRepository.Get(id);
            if (estudio == null)
                return NotFound();

            _estudioRepository.Delete(id);
            return NoContent();
        }
    }
}
