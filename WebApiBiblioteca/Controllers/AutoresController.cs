using Microsoft.AspNetCore.Mvc;
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
    public IEnumerable<Autor> Get()
    {
        return db.Autores.ToList();
    }

    [HttpPost]
    public ActionResult<Autor> Post(Autor autor)
    {
        db.Autores.Add(autor);
        db.SaveChanges();

        return Ok(autor);
    }
}