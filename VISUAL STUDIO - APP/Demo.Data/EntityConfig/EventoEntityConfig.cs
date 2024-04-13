using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

internal class EventoEntityConfig : IEntityTypeConfiguration<Evento>
{
    public void Configure(EntityTypeBuilder<Evento> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);

        builder.Property(e => e.Fecha)
            .IsRequired();

        builder.Property(e => e.Duracion)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.NroParticipantes)
            .IsRequired();

        builder.Property(e => e.IdComplejoDeporteUnico)
            .IsRequired();

        builder.Property(e => e.IdComplejoPolideportivo)
            .IsRequired();

        builder.HasOne(d => d.ComplejoDeporteUnico)
            .WithMany(p => p.Eventos)
            .HasForeignKey(d => d.IdComplejoDeporteUnico)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.ComplejoPolideportivo)
            .WithMany(p => p.Eventos)
            .HasForeignKey(d => d.IdComplejoPolideportivo)
            .OnDelete(DeleteBehavior.Restrict);
    }
}