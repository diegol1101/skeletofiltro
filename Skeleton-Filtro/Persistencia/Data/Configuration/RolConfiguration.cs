using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {

        builder.ToTable("rol");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("rolName")
        .HasColumnType("varchar")
        .HasMaxLength(255)
        .IsRequired();


        /*
        .HasMany(p => p.Roles)
           .WithMany(r => r.Users)
           .UsingEntity<UserRol>(
               j => j
               .HasOne(pt => pt.Rol)
               .WithMany(t => t.UsersRols)
               .HasForeignKey(ut => ut.RolId),
               j => j
               .HasOne(et => et.User)
               .WithMany(et => et.UsersRols)
               .HasForeignKey(el => el.UserId),
               j =>
               {
                   j.ToTable("userRol");
                   j.HasKey(t => new { t.UserId, t.RolId });
               });

        */

    }
}

