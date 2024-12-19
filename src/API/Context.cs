using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API;

public class Context : DbContext
{
    /// <summary>
    /// Tabla en la base de datos
    /// </summary>
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Opción en memoria
        optionsBuilder.UseInMemoryDatabase("Users");
        // Opción usando postgresql
        optionsBuilder.UseNpgsql("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=curso_net;");
    }
}