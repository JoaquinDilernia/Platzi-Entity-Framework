using Microsoft.EntityFrameworkCore;
using projecef.Models;

namespace projecef;


public class TareasContext : DbContext
{
    public TareasContext(DbContextOptions<TareasContext> options)
        : base(options)
    {
    }

    public DbSet<Tarea> Tareas { get; set; } = default!;
    public DbSet<Categoria> Categorias { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>().ToTable("Tarea");
        modelBuilder.Entity<Categoria>().ToTable("Categoria");
    }
}
