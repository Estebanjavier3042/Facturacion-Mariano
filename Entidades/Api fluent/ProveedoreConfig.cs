using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class ProveedoreConfig : IEntityTypeConfiguration<Proveedore>
    {
        public void Configure(EntityTypeBuilder<Proveedore> builder)
        {

            builder.HasKey(e => e.CodigoPv);

            builder.ToTable("proveedores");

            builder.Property(e => e.CodigoPv).HasColumnName("codigo_pv");
            builder.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");
            builder.Property(e => e.CodigoCi).HasColumnName("codigo_ci");
            builder.Property(e => e.CodigoRu).HasColumnName("codigo_ru");
            builder.Property(e => e.CodigoSx).HasColumnName("codigo_sx");
            builder.Property(e => e.CodigoTdpc).HasColumnName("codigo_tdpc");
            builder.Property(e => e.DireccionPv)
                    .HasColumnType("text")
                    .HasColumnName("direccion_pv");
            builder.Property(e => e.DocumentoPv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("documento_pv");
            builder.Property(e => e.EmailPv)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email_pv");
            builder.Property(e => e.Estado).HasColumnName("estado");
            builder.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_crea");
            builder.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifica");
            builder.Property(e => e.MovilPv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("movil_pv");
            builder.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombres");
            builder.Property(e => e.ObservacionPv)
                    .HasColumnType("text")
                    .HasColumnName("observacion_pv");
            builder.Property(e => e.RazonSocialPv)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("razon_social_pv");
            builder.Property(e => e.TelefonoPv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono_pv");

            builder.HasOne(d => d.CodigoCiNavigation).WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.CodigoCi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedores_ciudades");

            builder.HasOne(d => d.CodigoRuNavigation).WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.CodigoRu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedores_rubros");

            builder.HasOne(d => d.CodigoSxNavigation).WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.CodigoSx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedores_sexos");

            builder.HasOne(d => d.CodigoTdpcNavigation).WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.CodigoTdpc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedores_tipos_documento_pv_cl1");
           
        }
    }
}
