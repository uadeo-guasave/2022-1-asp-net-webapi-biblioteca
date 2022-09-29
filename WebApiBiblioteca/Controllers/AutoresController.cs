using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers;

[ApiController]
[Route("api/autores")]
public class AutoresController : ControllerBase
{
    // https://localhost:7248/api/autores
    [HttpGet]
    public IEnumerable<Autor> Get()
    {
        return new List<Autor>() {
            new Autor {Id=1, Nombre="bidkar"},
            new Autor {Id=2, Nombre="melisa"},
            new Autor {Id=3, Nombre="ricardo"}
        };
    }
}