using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models;

public class Autor
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; }
    public List<Libro> Libros { get; set; }
}
