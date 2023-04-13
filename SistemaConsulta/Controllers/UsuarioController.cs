using Microsoft.AspNetCore.Mvc;
using SistemaConsulta.Entity;
using SistemaConsulta.Repository.Interface;

namespace SistemaConsulta.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _usuarioRepository.GetUsuarios());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
}
