using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class CiudadeConfig : IEntityTypeConfiguration<Ciudade>
    {
        public void Configure(EntityTypeBuilder<Ciudade> builder)
        { 
                builder.HasKey(e => e.CodigoCi);

                builder.ToTable("ciudades");

                builder.Property(e => e.CodigoCi).HasColumnName("codigo_ci");
                builder.Property(e => e.CodigoDe).HasColumnName("codigo_de");
                builder.Property(e => e.DescripcionCi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_ci");
                builder.Property(e => e.Estado).HasColumnName("estado");

                builder.HasOne(d => d.CodigoDeNavigation).WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.CodigoDe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ciudades_departamentos");
        }
    }
}
