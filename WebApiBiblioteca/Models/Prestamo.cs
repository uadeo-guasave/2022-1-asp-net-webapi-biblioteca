using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models;
public class Prestamo
{
    public int Id { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    [Required]
    public DateTime FechaLimite { get; set; }
    public DateTime FechaDeRetorno { get; set; }
    public string Observaciones { get; set; }

    [Required]
    public int UsuarioId { get; set; }
    public int? DocenteId { get; set; }
    public int? AlumnoId { get; set; }
    
    // Propiedades para manejo de registros en EFCore
    [NotMapped]
    public Usuario Usuario { get; set; }

    [NotMapped]
    public Docente Docente { get; set; }

    [NotMapped]
    public Alumno Alumno { get; set; }
    
    [NotMapped]
    public List<Ejemplar> Ejemplares { get; set; }
}
