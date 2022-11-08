using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/autores")] // https://tusitio.com/api/autores
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
        var autores = await db.Autores.Include(a => a.Libros).ToListAsync();
        return autores;
    }

    [HttpPost]
    public async Task<ActionResult<Autor>> Post(Autor autor)
    {
        await db.Autores.AddAsync(autor);
        await db.SaveChangesAsync();

        return Ok(autor);
    }

    // [Route("{id:int}")] // https://tusition.com/api/autores/id
    [HttpPut("{id:int}")] // api/autores/4289  id = 4289
    public async Task<ActionResult> Update(Autor autor, int id)
    {
        if (id != autor.Id)
        {
            return BadRequest("El Id de la URL no coincide con el Id de Autor");
        }
        var existe = await db.Autores.AnyAsync(a => a.Id == id);
        if (!existe)
        {
            return NotFound();
        }

        db.Autores.Update(autor);
        await db.SaveChangesAsync();
        return Ok();
    }

    // [Route("{id:int}")]
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var existe = await db.Autores.AnyAsync(a => a.Id == id);
        if (!existe)
        {
            return NotFound();
        }

        db.Autores.Remove(new Autor { Id = id });
        await db.SaveChangesAsync();
        return Ok();

    }
}