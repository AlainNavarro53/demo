using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

public class ComplejoPolideportivoEntityConfig : IEntityTypeConfiguration<ComplejoPolideportivo>
{
    public void Configure(EntityTypeBuilder<ComplejoPolideportivo> builder)
    {
        builder.HasKey(p => p.Id);


        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);

        builder.Property(p => p.Localizacion).IsRequired().HasMaxLength(50);

        builder.Property(p => p.Area).IsRequired().HasPrecision(8, 2);

        builder.Property(e => e.IdComplejoDeportivo)
            .IsRequired();

        builder.HasOne(d => d.ComplejoDeportivo)
            .WithMany(p => p.ComplejoPolideportivo)
            .HasForeignKey(d => d.IdComplejoDeportivo)
            .OnDelete(DeleteBehavior.Restrict);
    }
}