using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

internal class EventoEquipamientoEntityConfig : IEntityTypeConfiguration<EventoEquipamiento>
{
    public void Configure(EntityTypeBuilder<EventoEquipamiento> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(e => e.IdEvento)
            .IsRequired();

        builder.Property(e => e.IdEquipamiento)
            .IsRequired();

        builder.HasOne(d => d.Evento)
            .WithMany(p => p.EventoEquipamiento)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Equipamiento)
            .WithMany(p => p.EventoEquipamiento)
            .HasForeignKey(d => d.IdEquipamiento)
            .OnDelete(DeleteBehavior.Restrict);
    }
}