using ApiUsuarios.Data;
using ApiUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUsuarios.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<Usuario> CreateAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            
            await _context.SaveChangesAsync();
            
            return usuario;
        }

        public async Task<Usuario> UpdateAsync(int id, Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            
            await _context.SaveChangesAsync();
            
            return usuario;
        }

        public async Task<bool> DeleteAsync(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            
            await _context.SaveChangesAsync();
            
            return true;
        }
    }
}