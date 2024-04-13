using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

public class ComplejoDeportivoEntityConfig : IEntityTypeConfiguration<ComplejoDeportivo>
{
    public void Configure(EntityTypeBuilder<ComplejoDeportivo> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Localizacion).IsRequired().HasMaxLength(50);

        builder.Property(p => p.JefeOrganizacion).IsRequired().HasMaxLength(50);

        builder.Property(e => e.AreaTotal)
            .IsRequired()
            .HasPrecision(8, 2);

        builder.Property(e => e.IdSedeOlimpica)
            .IsRequired();

        builder.HasOne(d => d.SedeOlimpica)
            .WithMany(p => p.ComplejosDeportivo)
            .HasForeignKey(d => d.IdSedeOlimpica)
            .OnDelete(DeleteBehavior.Restrict);
    }
}