using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.DTOs.Jogos;
using M3S9_jogos.webApi.Repositores;
using M3S9_jogos.webApi.Services.Jogo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosController : ControllerBase
    {
        private readonly IJogosService _jogoService;

        public JogosController(IJogosService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpGet]
        public IActionResult GetAllJogos()
        {
            var jogos = _jogoService.GetAllJogos();
            return Ok(jogos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var jogo = _jogoService.Get(id);
            if (jogo == null)
                return NotFound();

            return Ok(jogo);
        }

        [HttpPost]
        public IActionResult CreateJogo([FromBody] CreateJogoDTO dto)
        {
            var jogo = _jogoService.CreateJogoDTO(dto);
            return CreatedAtAction(nameof(Get), new { id = jogo.Id }, jogo);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJogo(int id, [FromBody] UpdateJogoDTO dto)
        {
            var jogo = _jogoService.UpdateJogoDTO(id, dto);
            if (jogo == null)
                return NotFound();

            return Ok(jogo);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _jogoService.Delete(id);
            if (!result)
            {
                return NotFound();
            }
                

            return NoContent();
        }
    }



}
