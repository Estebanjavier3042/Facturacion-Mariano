using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class TiposDocumentosEmitirConfig : IEntityTypeConfiguration<TiposDocumentosEmitir>
    {
        public void Configure(EntityTypeBuilder<TiposDocumentosEmitir> builder)
        {

            builder.HasKey(e => e.CodigoTde);

            builder.ToTable("tipos_documentos_emitir");

            builder.Property(e => e.CodigoTde).HasColumnName("codigo_tde");
            builder.Property(e => e.DescripcionTde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_tde");
            builder.Property(e => e.Estado).HasColumnName("estado");
            
        }
    }
}
