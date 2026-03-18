using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiUsuarios.Data;
using ApiUsuarios.Models;
using ApiUsuarios.Repositories;

namespace ApiUsuarios.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Usuario> CreateAsync(Usuario usuario)
        {
            await _repository.CreateAsync(usuario);
            
            return usuario;
        }

        public async Task<Usuario> UpdateAsync(int id, Usuario usuario)
        {
            var usuarioExistente = await _repository.GetByIdAsync(id);
            
            if (usuarioExistente == null)                
                return null;

            usuarioExistente.Nome = usuario.Nome;
            
            await _repository.UpdateAsync(id, usuarioExistente);
            
            return usuarioExistente;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var usuario = await _repository.GetByIdAsync(id);
            
            if (usuario == null)
                return false;

            await _repository.DeleteAsync(usuario);
            
            return true;
        }
    }
}