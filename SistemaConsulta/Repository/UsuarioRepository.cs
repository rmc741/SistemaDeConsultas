using SistemaConsulta.Entity;
using SistemaConsulta.Repository.Interface;

namespace SistemaConsulta.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    public Task<Usuario> AddUsuario(Usuario user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUsuario(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> GetUsuarioById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Usuario>> GetUsuarios()
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> UpdateUsuario(Usuario user, int id)
    {
        throw new NotImplementedException();
    }
}
