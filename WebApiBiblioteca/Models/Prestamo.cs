using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models;
public class Prestamo
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime FechaDeRetorno { get; set; }
    public string Observaciones { get; set; }
    public int UsuarioId { get; set; }
    public int? DocenteId { get; set; }
    public int? AlumnoId { get; set; }
    
    // Propiedades para manejo de registros en EFCore
    public Usuario Usuario { get; set; }
    public Docente Docente { get; set; }
    public Alumno Alumno { get; set; }
    public List<Ejemplar> Ejemplares { get; set; }
}
