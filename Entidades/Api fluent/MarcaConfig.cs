using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class MarcaConfig : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(e => e.CodigoMa);

            builder.ToTable("marcas");

            builder.Property(e => e.CodigoMa).HasColumnName("codigo_ma");
            builder.Property(e => e.DescripcionMa)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_ma");
            builder.Property(e => e.Estado).HasColumnName("estado");
           
        }
    }
}
