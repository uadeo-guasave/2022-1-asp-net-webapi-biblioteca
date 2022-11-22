using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models;

public class Alumno
{
    public int Id { get; set; }

    [Required]
    [MaxLength(8)]
    public string Matricula { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Nombres { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Apellidos { get; set; }
    
    [NotMapped]
    public List<Prestamo> Prestamos { get; set; }
}