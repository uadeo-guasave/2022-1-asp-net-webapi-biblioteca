using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Autor> Autores { get; set; }
    public DbSet<Editorial> Editoriales { get; set; }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Ejemplar> Ejemplares { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Docente> Docentes { get; set; }
    public DbSet<Alumno> Alumnos { get; set; }
}