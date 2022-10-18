using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/libros")]
public class LibrosController : ControllerBase
{
    private readonly AppDbContext db;

    public LibrosController(AppDbContext db)
    {
        this.db = db;
    }

    // https://localhost:xxxx/api/libros
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Libro>>> Get()
    {
        var libros = await db.Libros.Include(l => l.Autor).ToListAsync();
        return libros;
    }

    // TODO: Crear nuevos libros
    [HttpPost]
    public async Task<ActionResult> Post(Libro libro)
    {
        var existeLibro = await db.Libros.AnyAsync(l => l.Id == libro.Id);
        var existeAutor = await db.Autores.AnyAsync(a => a.Id == libro.AutorId);
        if (existeLibro || !existeAutor)
        {
            return BadRequest("Error: el libro ya existe o el autor no");
        }

        await db.Libros.AddAsync(libro);
        await db.SaveChangesAsync();
        return Ok();
    }
}