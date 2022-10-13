using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers;

public class LibrosController : ControllerBase
{
    private readonly AppDbContext db;

    public LibrosController(AppDbContext db)
    {
        this.db = db;
    }

    // TODO: Obtener los libros registrados
    // TODO: Crear nuevos libros
}