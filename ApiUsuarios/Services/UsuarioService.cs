using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiUsuarios.Services
{
    public class UsuarioService
    {
        public UsuarioService()
        {
        }

        public async Task<List<Usuario>> ObterTodosUsuariosAsync()
        {
            // TODO: Implement logic to retrieve all users
            throw new NotImplementedException();
        }

        public async Task<Usuario> ObterUsuarioPorIdAsync(int id)
        {
            // TODO: Implement logic to retrieve user by id
            throw new NotImplementedException();
        }

        public async Task<Usuario> CriarUsuarioAsync(Usuario usuario)
        {
            // TODO: Implement logic to create a new user
            throw new NotImplementedException();
        }

        public async Task<Usuario> AtualizarUsuarioAsync(int id, Usuario usuario)
        {
            // TODO: Implement logic to update a user
            throw new NotImplementedException();
        }

        public async Task<bool> DeletarUsuarioAsync(int id)
        {
            // TODO: Implement logic to delete a user
            throw new NotImplementedException();
        }
    }
}