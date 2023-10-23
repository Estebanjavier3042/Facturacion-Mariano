using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class DetEntradaProductoConfig : IEntityTypeConfiguration<DetEntradaProducto>
    {
        public void Configure(EntityTypeBuilder<DetEntradaProducto> builder)
        {

            builder.HasKey(e => new { e.CodigoEp, e.CodigoPr });
            builder.ToTable("det_entrada_productos");

            builder.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("cantidad");
            builder.Property(e => e.CodigoEp).HasColumnName("codigo_ep");
            builder.Property(e => e.CodigoPr).HasColumnName("codigo_pr");
            builder.Property(e => e.PuCompra)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pu_compra");
            builder.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");
            //aca modifique
            builder.HasOne(d => d.EncEntradaProducto).WithMany(d => d.DetEntradaProductos)
                    .HasForeignKey(d => d.CodigoEp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_det_entrada_productos_enc_entrada_productos");
           
        }
    }
}
