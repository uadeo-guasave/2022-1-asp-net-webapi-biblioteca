using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models;

public class Ejemplar
{
    public int Id { get; set; }

    [Required]
    public int LibroId { get; set; }

    [Required]
    public DateTime FechaDeIngreso { get; set; }

    [Required]
    public Double Costo { get; set; }

    [Required]
    [MaxLength(100)]
    public string Condiciones { get; set; }

    [NotMapped]
    public Libro Libro { get; set; }
    
    [NotMapped]
    public List<Prestamo> Prestamos { get; set; }
}