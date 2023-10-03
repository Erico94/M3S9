﻿using AutoMapper;
using M3S9_jogos.webApi.Domain;
using M3S9_jogos.webApi.DTOs.Estudios;
using M3S9_jogos.webApi.DTOs.Jogos;
using M3S9_jogos.webApi.Repositores;
using M3S9_jogos.webApi.Services.Jogo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M3S9_jogos.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        readonly IJogosService _jogosService;

        public JogosController(IJogosService jogosService)
        {
            _jogosService = jogosService;
        }

        [HttpGet]
        public ActionResult<ViewJogoDTO> Get()
        {
            List<Jogo> jogos = _jogoRepository.Get();
            if (jogos == null || jogos.Count == 0)
            {
                return NoContent();
            }
            var listDto = _mapper.Map<List<ViewJogoDTO>>(jogos);
            return Ok(listDto);
        }
        [HttpGet("{id}")]
        public ActionResult<ViewJogoDTO> Get(int id)
        {
            Jogo jogo = _jogoRepository.Get(id);
            if (jogo == null)
            {
                return NotFound();
            }
            var dto = _mapper.
                Map<ViewJogoDTO>(jogo);

            return Ok(dto);
        }

        [HttpPost]
        public ActionResult<ViewJogoDTO> Post(CreateJogoDTO dto)
        {
            var jogo = _mapper.Map<Jogo>(dto);
            _jogoRepository.Insert(jogo);

            //var viewJogoDto = _mapper.Map<ViewJogoDTO>(jogo);

            return Ok(jogo);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, UpdateJogoDTO dto)
        {
            if (_jogoRepository.Get(id) == null)
                return NotFound();

            var jogo = _mapper.Map<Jogo>(dto);
            if (jogo.Id != id)
                return BadRequest();

            _jogoRepository.Update(jogo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var jogo = _jogoRepository.Get(id);
            if (jogo == null)
                return NotFound();

            _jogoService.Delete
            return NoContent();
        }


    }
}
