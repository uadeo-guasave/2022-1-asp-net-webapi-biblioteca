using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/ejemplares")]
public class EjemplarController : ControllerBase
{
    private readonly AppDbContext db;

    public EjemplarController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ejemplar>>> Get()
    {
        return await db.Ejemplares.Include(e => e.Libro).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Ejemplar>> Post(Ejemplar ejemplar)
    {
        await db.Ejemplares.AddAsync(ejemplar);
        await db.SaveChangesAsync();
        return Ok(ejemplar);
    }
}