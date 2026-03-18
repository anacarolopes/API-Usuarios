using ApiUsuarios.Models;

namespace ApiUsuarios.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario> GetByIdAsync(int id);
        Task<Usuario> CreateAsync(Usuario usuario);
        Task<Usuario> UpdateAsync(int id, Usuario usuario);
        Task<bool> DeleteAsync(Usuario usuario);
    }
}