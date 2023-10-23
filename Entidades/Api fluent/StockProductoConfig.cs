using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class StockProductoConfig : IEntityTypeConfiguration<StockProducto>
    {
        public void Configure(EntityTypeBuilder<StockProducto> builder)
        {

            // aca cambie... antes entity.HasNoKey()
            builder.HasKey(x => new { x.CodigoPr, x.CodigoAl }).HasName("PK_Stock_Producto_1");
            builder.ToTable("stock_productos");

            builder.Property(e => e.CodigoAl).HasColumnName("codigo_al");
            builder.Property(e => e.CodigoPr).HasColumnName("codigo_pr");
            builder.Property(e => e.PuCompra)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pu_compra");
            builder.Property(e => e.StockActual)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("stock_actual");

            builder.HasOne(d => d.CodigoAlNavigation).WithMany(d => d.StockProductos)
                    .HasForeignKey(d => d.CodigoAl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stock_productos_almacenes");

            builder.HasOne(d => d.CodigoPrNavigation).WithMany(d => d.StockProductos)
                    .HasForeignKey(d => d.CodigoPr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stock_productos_productos");
           
        }
    }
}
