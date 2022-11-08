using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/usuarios")]
public class UsuarioController : ControllerBase
{
    private readonly AppDbContext db;

    public UsuarioController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Usuario>>> Get()
    {
        return await db.Usuarios.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Usuario>> Post(Usuario usuario)
    {
        await db.Usuarios.AddAsync(usuario);
        await db.SaveChangesAsync();
        return Ok(usuario);
    }
}