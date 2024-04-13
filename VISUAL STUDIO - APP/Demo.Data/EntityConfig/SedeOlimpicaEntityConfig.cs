using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

public class SedeOlimpicaEntityConfig : IEntityTypeConfiguration<SedeOlimpica>
{
    public void Configure(EntityTypeBuilder<SedeOlimpica> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Ubicacion).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Presupuesto).IsRequired().HasPrecision(8, 2);
    }
}