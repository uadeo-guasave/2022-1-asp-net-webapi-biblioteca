namespace WebApiBiblioteca.Models;

public class Editorial
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Domicilio { get; set; }
    public List<Libro> Libros { get; set; }
}