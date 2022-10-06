using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/autores")]
public class AutoresController : ControllerBase
{
    private readonly AppDbContext db;

    public AutoresController(AppDbContext db)
    {
        this.db = db;
    }

    // https://localhost:7248/api/autores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Autor>>> Get()
    {
        var autores = await db.Autores.ToListAsync();
        return autores;
    }

    [HttpPost]
    public async Task<ActionResult<Autor>> Post(Autor autor)
    {
        await db.Autores.AddAsync(autor);
        await db.SaveChangesAsync();

        return Ok(autor);
    }
}