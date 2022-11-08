using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/editoriales")]
public class EditorialController : ControllerBase
{
    private readonly AppDbContext db;

    public EditorialController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Editorial>>> Get()
    {
        return await db.Editoriales.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Editorial>> Post(Editorial editorial)
    {
        await db.Editoriales.AddAsync(editorial);
        await db.SaveChangesAsync();
        return Ok(editorial);
    }
}