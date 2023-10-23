using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class TiposDocumentoPvClConfig : IEntityTypeConfiguration<TiposDocumentoPvCl>
    {
        public void Configure(EntityTypeBuilder<TiposDocumentoPvCl> builder)
        {
            builder.HasKey(e => e.CodigoTdpc);

            builder.ToTable("tipos_documento_pv_cl");

            builder.Property(e => e.CodigoTdpc).HasColumnName("codigo_tdpc");
            builder.Property(e => e.DescripcionTdpc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_tdpc");
            builder.Property(e => e.Estado).HasColumnName("estado");
           

        }
    }
}
