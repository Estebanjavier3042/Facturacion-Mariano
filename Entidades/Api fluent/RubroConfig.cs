using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class RubroConfig : IEntityTypeConfiguration<Rubro>
    {
        public void Configure(EntityTypeBuilder<Rubro> builder)
        {
            builder.HasKey(e => e.CodigoRu);

            builder.ToTable("rubros");

            builder.Property(e => e.CodigoRu).HasColumnName("codigo_ru");
            builder.Property(e => e.DescripcionRu)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_ru");
            builder.Property(e => e.Estado).HasColumnName("estado");
            
        }
    }
}
