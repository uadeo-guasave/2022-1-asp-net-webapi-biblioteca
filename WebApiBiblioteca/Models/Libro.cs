using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models;

public class Libro
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Titulo { get; set; }

    [Required]
    public int Edicion { get; set; }

    [Required]
    public int AutorId { get; set; }

    [Required]
    public int EditorialId { get; set; }

    [NotMapped]
    public Autor Autor { get; set; }

    [NotMapped]
    public Editorial Editorial { get; set; }

    [NotMapped]
    public List<Ejemplar> Ejemplares { get; set; }
}