using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

public class ComisarioEntityConfig : IEntityTypeConfiguration<Comisario>
{
    public void Configure(EntityTypeBuilder<Comisario> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);

        builder.Property(p => p.Tipo).IsRequired().HasMaxLength(50);

        builder.HasOne(d => d.Evento)
            .WithMany(p => p.Comisarios)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.Restrict);
    }
}