using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class UnidadesMedidaConfig : IEntityTypeConfiguration<UnidadesMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadesMedida> builder)
        {

            builder.HasKey(e => e.CodigoUm);

            builder.ToTable("unidades_medidas");

            builder.Property(e => e.CodigoUm).HasColumnName("codigo_um");
            builder.Property(e => e.AbreviaturaUm)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("abreviatura_um");
            builder.Property(e => e.DescripcionUm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_um");
            builder.Property(e => e.Estado).HasColumnName("estado");
           
        }
    }
}
