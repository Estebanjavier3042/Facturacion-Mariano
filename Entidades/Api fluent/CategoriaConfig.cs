using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.Core.Objects.DataClasses;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.HasKey(e => e.CodigoCa);

            builder.ToTable("categorias");

            builder.Property(e => e.CodigoCa).HasColumnName("codigo_ca");
            builder.Property(e => e.DescripcionCa)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_ca");
            builder.Property(e => e.Estado).HasColumnName("estado");
        }   
    }
}
