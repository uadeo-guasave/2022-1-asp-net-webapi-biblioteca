using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/prestamos")]
public class PrestamoController : ControllerBase
{
    private readonly AppDbContext db;

    public PrestamoController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Prestamo>>> Get()
    {
        return await db.Prestamos
            .Include(p => p.Usuario)
            .Include(p => p.Alumno)
            .Include(p => p.Docente)
            .Include(p => p.Ejemplares)
                .ThenInclude(e => e.Libro)
                    .ThenInclude(l => l.Autor)
            .Include(p => p.Ejemplares)
                .ThenInclude(e => e.Libro)
                    .ThenInclude(l => l.Editorial)
            .ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Prestamo>> Post(Prestamo prestamo)
    {
        await db.Prestamos.AddAsync(prestamo);
        await db.SaveChangesAsync();
        return Ok(prestamo);
    }
}