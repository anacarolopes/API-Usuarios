using Microsoft.AspNetCore.Mvc;
using ApiUsuarios.Services;
using ApiUsuarios.Models;
using ApiUsuarios.DTOs;

namespace ApiUsuarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        
        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _service.GetAllAsync();

            return Ok(usuarios);    
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _service.GetByIdAsync(id);
            
            if (usuario == null)
                return NotFound();
                
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UsuarioCreateDto dto)
        {
                var usuario = new Usuario
                {
                    Nome = dto.Nome,
                };
                
                var novo = await _service.CreateAsync(usuario);

                var response = new UsuarioResponseDto
                {
                    Id = novo.Id,
                    Nome = novo.Nome,
                    DataCriacao = novo.DataCriacao
                };

                return Ok(response);
           
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Usuario usuario)
        {
           var atualizado = await _service.UpdateAsync(id, usuario);

            if (atualizado == null)
                return NotFound();

            return Ok(atualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
                var removido = await _service.DeleteAsync(id);

                if (!removido)
                    return NotFound();

                return NoContent();            
        }
    }

}