using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {

            builder.HasKey(e => e.CodigoPr);

            builder.ToTable("productos");

            builder.Property(e => e.CodigoPr).HasColumnName("codigo_pr");
            builder.Property(e => e.CodigoCa).HasColumnName("codigo_ca");
            builder.Property(e => e.CodigoMa).HasColumnName("codigo_ma");
            builder.Property(e => e.CodigoUm).HasColumnName("codigo_um");
            builder.Property(e => e.DescripcionPr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_pr");
            builder.Property(e => e.Estado).HasColumnName("estado");
            builder.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");
            builder.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifica");
            builder.Property(e => e.StockMax)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("stock_max");
            builder.Property(e => e.StockMin)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("stock_min");

            builder.HasOne(d => d.CodigoCaNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CodigoCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_productos_categorias");

            builder.HasOne(d => d.CodigoMaNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CodigoMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_productos_marcas");

            builder.HasOne(d => d.CodigoUmNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CodigoUm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_productos_unidades_medidas");
           
        }
    }
}
