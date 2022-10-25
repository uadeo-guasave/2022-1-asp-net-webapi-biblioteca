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
}