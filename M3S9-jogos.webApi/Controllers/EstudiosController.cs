using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudioController : ControllerBase
    {
        private readonly IEstudioServices _estudioServices;

        public EstudioController(IEstudioServices estudioServices)
        {
            _estudioServices = estudioServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var estudios = _estudioServices.Get();
            return Ok(estudios);
        }

        [HttpGet("{id}")]
        public IActionResult GetEstudioById(int id)
        {
            var estudio = _estudioServices.GetEstudioById(id);
            if (estudio == null)
                return NotFound();

            return Ok(estudio);
        }

        [HttpPost]
        public IActionResult CreateEstudio([FromBody] CreateEstudioDTO estudioCreateDTO)
        {
            var estudio = _estudioServices.CreateEstudioDTO(estudioCreateDTO);
            return CreatedAtAction(nameof(GetEstudioById), new { id = estudio.Id }, estudio);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEstudio(int id, [FromBody] UpdateEstudioDTO updateEstudioDTO)
        {
            var estudio = _estudioServices.UpdateEstudioDTO(id, updateEstudioDTO);
            if (estudio == null)
                return NotFound();

            return Ok(estudio);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEstudio(int id)
        {
            var result = _estudioServices.DeleteEstudio(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }

}
