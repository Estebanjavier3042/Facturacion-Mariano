using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace baseDatosMariano.Entidades.Api_fluent
{
    public class DepartamentoConfig : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasKey(e => e.CodigoDe);

            builder.ToTable("departamentos");

            builder.Property(e => e.CodigoDe).HasColumnName("codigo_de");
            builder.Property(e => e.CodigoProv).HasColumnName("codigo_prov");
            builder.Property(e => e.DescripcionDe)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_de");
            builder.Property(e => e.Estado).HasColumnName("estado");

            builder.HasOne(d => d.CodigoProvNavigation).WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.CodigoProv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_departamentos_provincias");
           
        }
    }
}
