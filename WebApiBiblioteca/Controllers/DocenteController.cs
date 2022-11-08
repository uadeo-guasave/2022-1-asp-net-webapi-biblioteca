using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/docentes")]
public class DocenteController : ControllerBase
{
    private readonly AppDbContext db;

    public DocenteController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Docente>>> Get()
    {
        return await db.Docentes.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Docente>> Post(Docente docente)
    {
        await db.Docentes.AddAsync(docente);
        await db.SaveChangesAsync();
        return Ok(docente);
    }
}