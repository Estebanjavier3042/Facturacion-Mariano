using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class SexoConfig : IEntityTypeConfiguration<Sexo>
    {
        public void Configure(EntityTypeBuilder<Sexo> builder)
        {

            builder.HasKey(e => e.CodigoSx);

            builder.ToTable("sexos");

            builder.Property(e => e.CodigoSx).HasColumnName("codigo_sx");
            builder.Property(e => e.DescripcionSx)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_sx");
            builder.Property(e => e.Estado).HasColumnName("estado");
           
        }
    }
}
