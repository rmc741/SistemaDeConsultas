using Microsoft.AspNetCore.Mvc;
using SistemaConsulta.Entity;
using SistemaConsulta.Repository.Interface;

namespace SistemaConsulta.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    List<Usuario> usuarios = new List<Usuario>();
    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        usuarios.Add(new Usuario(1 , "User 1", "email" , "senha" , "situacao"));
        usuarios.Add(new Usuario(2, "User 2", "email", "senha", "situacao"));
        usuarios.Add(new Usuario(3, "User 3", "email", "senha", "situacao"));
        usuarios.Add(new Usuario(4, "User 4", "email", "senha", "situacao"));
        _usuarioRepository = usuarioRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(usuarios);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var usuarioById = usuarios.FirstOrDefault(u => u.Id == id);
        return usuarioById != null ? Ok(usuarioById) : BadRequest("Não achei o usuario!");
    }
}
