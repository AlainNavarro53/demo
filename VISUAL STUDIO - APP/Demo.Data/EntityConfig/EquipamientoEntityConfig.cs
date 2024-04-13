using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

public class EquipamientoEntityConfig : IEntityTypeConfiguration<Equipamiento>
{
    public void Configure(EntityTypeBuilder<Equipamiento> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(e => e.Tipo)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.IdEvento)
            .IsRequired();

        builder.HasOne(d => d.Evento)
            .WithMany(p => p.Equipamiento)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.Restrict);
    }
}