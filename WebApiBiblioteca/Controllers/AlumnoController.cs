using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/alumnos")]
public class AlumnoController : ControllerBase
{
    private readonly AppDbContext db;

    public AlumnoController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Alumno>>> Get()
    {
        return await db.Alumnos.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Alumno>> Post(Alumno alumno)
    {
        await db.Alumnos.AddAsync(alumno);
        await db.SaveChangesAsync();
        return Ok(alumno);
    }
}