using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models;

public class Editorial
{
    public int Id { get; set; }

    [Required]
    [MaxLength(120)]
    public string Nombre { get; set; }

    [MaxLength(200)]
    public string Domicilio { get; set; }

    [NotMapped]
    public List<Libro> Libros { get; set; }
}