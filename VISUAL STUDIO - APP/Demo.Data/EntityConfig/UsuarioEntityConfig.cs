using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.EntityConfig;

public class UsuarioEntityConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.FullName).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Username).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Password).IsRequired().HasMaxLength(50);
    }
}