using SistemaConsulta.Entity;

namespace SistemaConsulta.Repository.Interface;

public interface IUsuarioRepository
{
    Task<List<Usuario>> GetUsuarios();
    Task<Usuario> GetUsuarioById(int id);
    Task<Usuario> AddUsuario(Usuario user);
    Task<Usuario> UpdateUsuario(Usuario user, int id);
    Task<bool> DeleteUsuario(int id);
}
