namespace WebApiBiblioteca.Models;

public class Docente
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Rfc { get; set; }
    public List<Prestamo> Prestamos { get; set; }
}