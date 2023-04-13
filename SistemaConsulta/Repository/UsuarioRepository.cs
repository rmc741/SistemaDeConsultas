using Microsoft.EntityFrameworkCore;
using SistemaConsulta.Data;
using SistemaConsulta.Entity;
using SistemaConsulta.Repository.Interface;

namespace SistemaConsulta.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly SistemaConsultaContext _context;

    public UsuarioRepository(SistemaConsultaContext context)
    {
        _context = context;
    }
    public async Task<List<Usuario>> GetUsuarios()
    {
        return await _context.Usuarios.ToListAsync();
    }
    public Task<Usuario> GetUsuarioById(int id)
    {
        throw new NotImplementedException();
    }
    public Task<Usuario> AddUsuario(Usuario user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUsuario(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> UpdateUsuario(Usuario user, int id)
    {
        throw new NotImplementedException();
    }
}
