namespace WebApiBiblioteca.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Alias { get; set; }
    public string CorreoElectronico { get; set; }
    public string Contraseña { get; set; }
    public string Recordatorio { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    // public List<Prestamo> Prestamos { get; set; }
}