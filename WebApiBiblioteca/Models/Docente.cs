using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models;

public class Docente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nombres { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Apellidos { get; set; }

    [Required]
    [MaxLength(13)]
    public string Rfc { get; set; }

    [NotMapped]
    public List<Prestamo> Prestamos { get; set; }
}