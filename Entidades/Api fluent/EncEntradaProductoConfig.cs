using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class EncEntradaProductoConfig : IEntityTypeConfiguration<EncEntradaProducto>
    {
        public void Configure(EntityTypeBuilder<EncEntradaProducto> builder)
        {

            builder.HasKey(e => e.CodigoEp);

            builder.ToTable("enc_entrada_productos");

            builder.Property(e => e.CodigoEp).HasColumnName("codigo_ep");
            builder.Property(e => e.CodigoAl).HasColumnName("codigo_al");
            builder.Property(e => e.CodigoPv).HasColumnName("codigo_pv");
            builder.Property(e => e.CodigoTde).HasColumnName("codigo_tde");
            builder.Property(e => e.Estado).HasColumnName("estado");
            builder.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_crea");
            builder.Property(e => e.FechaEp)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ep");
            builder.Property(e => e.Iva)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("iva");
            builder.Property(e => e.NrodocumentoEp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nrodocumento_ep");
            builder.Property(e => e.ObservacionEp)
                    .HasColumnType("text")
                    .HasColumnName("observacion_ep");
            builder.Property(e => e.Subtotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("subtotal");
            builder.Property(e => e.TotalImporte)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total_importe");

            builder.HasOne(d => d.CodigoAlNavigation).WithMany(p => p.EncEntradaProductos)
                    .HasForeignKey(d => d.CodigoAl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_enc_entrada_productos_almacenes");

            builder.HasOne(d => d.CodigoPvNavigation).WithMany(p => p.EncEntradaProductos)
                    .HasForeignKey(d => d.CodigoPv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_enc_entrada_productos_proveedores");

            builder.HasOne(d => d.CodigoTdeNavigation).WithMany(p => p.EncEntradaProductos)
                    .HasForeignKey(d => d.CodigoTde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_enc_entrada_productos_tipos_documentos_emitir");
           
        }
    }
}
