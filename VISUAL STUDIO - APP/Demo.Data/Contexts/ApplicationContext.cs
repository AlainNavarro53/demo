using Demo.Data.EntityConfig;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data.Contexts;

public class ApplicationContext : DbContext
{
    // Connections options to DB 
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    // Configuration of the models (Tables) that i am going to use
    public DbSet<Comisario> Comisario { get; set; }
    public DbSet<ComplejoDeporteUnico> ComplejoDeporteUnico { get; set; }
    public DbSet<ComplejoDeportivo> ComplejoDeportivo { get; set; }
    public DbSet<ComplejoPolideportivo> ComplejoPolideportivo { get; set; }
    public DbSet<Equipamiento> Equipamiento { get; set; }
    public DbSet<Evento> Evento { get; set; }
    public DbSet<EventoEquipamiento> EventoEquipamiento { get; set; }
    public DbSet<SedeOlimpica> SedeOlimpica { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    //Configurations Tables

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ComplejoDeporteUnicoEntityConfig());
        modelBuilder.ApplyConfiguration(new ComisarioEntityConfig());
        modelBuilder.ApplyConfiguration(new ComplejoDeportivoEntityConfig());
        modelBuilder.ApplyConfiguration(new ComplejoPolideportivoEntityConfig());
        modelBuilder.ApplyConfiguration(new EquipamientoEntityConfig());
        modelBuilder.ApplyConfiguration(new EventoEquipamientoEntityConfig());
        modelBuilder.ApplyConfiguration(new EventoEntityConfig());
        modelBuilder.ApplyConfiguration(new SedeOlimpicaEntityConfig());
        modelBuilder.ApplyConfiguration(new UsuarioEntityConfig());
    }
}