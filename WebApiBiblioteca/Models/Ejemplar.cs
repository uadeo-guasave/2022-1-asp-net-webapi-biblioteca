namespace WebApiBiblioteca.Models;

public class Ejemplar
{
    public int Id { get; set; }
    public int LibroId { get; set; }
    public DateTime FechaDeIngreso { get; set; }
    public Double Costo { get; set; }
    public string Condiciones { get; set; }
    public Libro Libro { get; set; }
}