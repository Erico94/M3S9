using M3S9_jogos.webApi.Domain;
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

        public EstudiosController(EstudioRepository estudioRepository)
        {
            _estudioRepository = estudioRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Estudio>> Get()
        {
            List<Estudio> estudios = _estudioRepository.Get();
            if (estudios == null || estudios.Count == 0)
            {
                return NoContent();
            }
            return Ok(estudios);
        }
        [HttpGet("{id}")]
        public ActionResult<Estudio> Get(int id)
        {
            Estudio estudio = _estudioRepository.Get(id);
            if (estudio == null)
            {
                return NotFound();
            }
            return Ok(estudio);
        }

        [HttpPost]
        public ActionResult<Estudio> Post(Estudio estudio)
        {
            _estudioRepository.Insert(estudio);

            return Ok(estudio);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Estudio estudio)
        {
            if (_estudioRepository.Get(id) == null)
                return NotFound();
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
