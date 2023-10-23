using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class ProvinciaConfig : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {

            builder.HasKey(e => e.CodigoProv);

            builder.ToTable("provincias");

            builder.Property(e => e.CodigoProv).HasColumnName("codigo_prov");
            builder.Property(e => e.DescripcionProv)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_prov");
            builder.Property(e => e.Estado).HasColumnName("estado");
           
        }
    }
}
