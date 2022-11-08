using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models;

public class Usuario
{
    public int Id { get; set; }

    [Required]
    [MaxLength(16)]
    public string Alias { get; set; }

    [Required]
    [EmailAddress]
    public string CorreoElectronico { get; set; }

    [Required]
    public string Contraseña { get; set; }
    public string Recordatorio { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nombres { get; set; }

    [Required]
    [MaxLength(50)]
    public string Apellidos { get; set; }
    public List<Prestamo> Prestamos { get; set; }
}