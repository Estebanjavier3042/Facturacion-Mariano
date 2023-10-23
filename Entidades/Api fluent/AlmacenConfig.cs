using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class AlmacenConfig : IEntityTypeConfiguration<Almacene>
    {
        public void Configure(EntityTypeBuilder<Almacene> builder)
        { 
                builder.HasKey(e => e.CodigoAl);

                builder.ToTable("almacenes");

            builder.Property(e => e.CodigoAl).HasColumnName("codigo_al");
            builder.Property(e => e.DescripcionAl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_al");
            builder.Property(e => e.Estado).HasColumnName("estado");
            
        }
    }
}
