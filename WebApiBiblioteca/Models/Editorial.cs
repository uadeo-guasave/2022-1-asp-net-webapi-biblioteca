using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models;

public class Editorial
{
    public int Id { get; set; }

    [Required]
    [MaxLength(120)]
    public string Nombre { get; set; }

    [MaxLength(200)]
    public string Domicilio { get; set; }
    public List<Libro> Libros { get; set; }
}