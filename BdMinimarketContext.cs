using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Reflection;
using baseDatosMariano.Entidades;
using Microsoft.EntityFrameworkCore;


namespace baseDatosMariano;

public partial class BdMinimarketContext : DbContext
{


    public BdMinimarketContext(DbContextOptions<BdMinimarketContext> options): base(options)
    {
    }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Ciudade> Ciudades { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetEntradaProducto> DetEntradaProductos { get; set; }

    public virtual DbSet<EncEntradaProducto> EncEntradaProductos { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<Sexo> Sexos { get; set; }

    public virtual DbSet<StockProducto> StockProductos { get; set; }

    public virtual DbSet<TiposDocumentoPvCl> TiposDocumentoPvCls { get; set; }

    public virtual DbSet<TiposDocumentosEmitir> TiposDocumentosEmitirs { get; set; }

    public virtual DbSet<UnidadesMedida> UnidadesMedidas { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {              
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
                             //data seeding Ciudades
        modelBuilder.Entity<Ciudade>().HasData(
            new Ciudade { CodigoCi=7, DescripcionCi = "Alvear", CodigoDe = 1, Estado = true },
            new Ciudade { CodigoCi =8, DescripcionCi = "Alvarez", CodigoDe = 1, Estado = true },
            new Ciudade { CodigoCi =9, DescripcionCi = "Acebal", CodigoDe = 1, Estado = true },
            new Ciudade { CodigoCi =10, DescripcionCi = "Casilda", CodigoDe = 1, Estado = true });
                            //data seeding Provincia
        modelBuilder.Entity<Provincia>().HasData(
            new Provincia { CodigoProv=2,DescripcionProv = "Buenos Aires",Estado=true },
            new Provincia { CodigoProv =3, DescripcionProv ="Cordoba",Estado=true },
            new Provincia { CodigoProv =4, DescripcionProv ="Entre Rios",Estado=true },
            new Provincia { CodigoProv =5, DescripcionProv ="Mendoza",Estado=true },
            new Provincia { CodigoProv =6, DescripcionProv ="Corrientes",Estado=true });
                           //data seeding Ciudades Departamento
        modelBuilder.Entity<Departamento>().HasData(
            new Departamento { CodigoDe=2, DescripcionDe ="Constitucion", CodigoProv =1,Estado=true },
            new Departamento { CodigoDe =3, DescripcionDe ="Iriondo", CodigoProv =1,Estado=true },
            new Departamento { CodigoDe =4, DescripcionDe ="San Lorenzo", CodigoProv =1,Estado=true },
            new Departamento { CodigoDe =5, DescripcionDe ="San Jeronimo", CodigoProv =1,Estado=true });
                         //data seeding UnidadesMedida
        modelBuilder.Entity<UnidadesMedida>().HasData(
           new UnidadesMedida { CodigoUm=2, AbreviaturaUm ="Lts",DescripcionUm="Litros",Estado=true},
           new UnidadesMedida { CodigoUm =3, AbreviaturaUm ="m",DescripcionUm="Metros",Estado=true});
        modelBuilder.Entity<Almacene>().HasData(
            new Almacene { CodigoAl=2,DescripcionAl = "SucAlvear",Estado=true },
            new Almacene { CodigoAl = 3, DescripcionAl ="SucAlvarez",Estado=true },
            new Almacene { CodigoAl = 4, DescripcionAl ="SucRoldan",Estado=true },
            new Almacene { CodigoAl = 5, DescripcionAl ="SucFunes",Estado=true });

        //modelBuilder.Entity<Almacene>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoAl);

        //    entity.ToTable("almacenes");

        //    entity.Property(e => e.CodigoAl).HasColumnName("codigo_al");
        //    entity.Property(e => e.DescripcionAl)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_al");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<Categoria>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoCa);

        //    entity.ToTable("categorias");

        //    entity.Property(e => e.CodigoCa).HasColumnName("codigo_ca");
        //    entity.Property(e => e.DescripcionCa)
        //        .HasMaxLength(40)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_ca");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<Ciudade>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoCi);

        //    entity.ToTable("ciudades");

        //    entity.Property(e => e.CodigoCi).HasColumnName("codigo_ci");
        //    entity.Property(e => e.CodigoDe).HasColumnName("codigo_de");
        //    entity.Property(e => e.DescripcionCi)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_ci");
        //    entity.Property(e => e.Estado).HasColumnName("estado");

        //    entity.HasOne(d => d.CodigoDeNavigation).WithMany(p => p.Ciudades)
        //        .HasForeignKey(d => d.CodigoDe)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_ciudades_departamentos");
        //});

        //modelBuilder.Entity<Departamento>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoDe);

        //    entity.ToTable("departamentos");

        //    entity.Property(e => e.CodigoDe).HasColumnName("codigo_de");
        //    entity.Property(e => e.CodigoProv).HasColumnName("codigo_prov");
        //    entity.Property(e => e.DescripcionDe)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_de");
        //    entity.Property(e => e.Estado).HasColumnName("estado");

        //    entity.HasOne(d => d.CodigoProvNavigation).WithMany(p => p.Departamentos)
        //        .HasForeignKey(d => d.CodigoProv)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_departamentos_provincias");
        //});

        //modelBuilder.Entity<DetEntradaProducto>(entity =>
        //{
        //    entity.HasKey(e =>  new { e.CodigoEp, e.CodigoPr });
        //    entity.ToTable("det_entrada_productos");

        //    entity.Property(e => e.Cantidad)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("cantidad");
        //    entity.Property(e => e.CodigoEp).HasColumnName("codigo_ep");
        //    entity.Property(e => e.CodigoPr).HasColumnName("codigo_pr");
        //    entity.Property(e => e.PuCompra)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("pu_compra");
        //    entity.Property(e => e.Total)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("total");
        //    //aca modifique
        //    entity.HasOne(d => d.EncEntradaProducto).WithMany(d=>d.DetEntradaProductos)
        //        .HasForeignKey(d => d.CodigoEp)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_det_entrada_productos_enc_entrada_productos");
        //});

        //modelBuilder.Entity<EncEntradaProducto>(entity =>
        //{
        //    entity.HasKey(e =>e.CodigoEp);

        //    entity.ToTable("enc_entrada_productos");

        //    entity.Property(e => e.CodigoEp).HasColumnName("codigo_ep");
        //    entity.Property(e => e.CodigoAl).HasColumnName("codigo_al");
        //    entity.Property(e => e.CodigoPv).HasColumnName("codigo_pv");
        //    entity.Property(e => e.CodigoTde).HasColumnName("codigo_tde");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //    entity.Property(e => e.FechaCrea)
        //        .HasColumnType("datetime")
        //        .HasColumnName("fecha_crea");
        //    entity.Property(e => e.FechaEp)
        //        .HasColumnType("date")
        //        .HasColumnName("fecha_ep");
        //    entity.Property(e => e.Iva)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("iva");
        //    entity.Property(e => e.NrodocumentoEp)
        //        .HasMaxLength(30)
        //        .IsUnicode(false)
        //        .HasColumnName("nrodocumento_ep");
        //    entity.Property(e => e.ObservacionEp)
        //        .HasColumnType("text")
        //        .HasColumnName("observacion_ep");
        //    entity.Property(e => e.Subtotal)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("subtotal");
        //    entity.Property(e => e.TotalImporte)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("total_importe");

        //    entity.HasOne(d => d.CodigoAlNavigation).WithMany(p => p.EncEntradaProductos)
        //        .HasForeignKey(d => d.CodigoAl)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_enc_entrada_productos_almacenes");

        //    entity.HasOne(d => d.CodigoPvNavigation).WithMany(p => p.EncEntradaProductos)
        //        .HasForeignKey(d => d.CodigoPv)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_enc_entrada_productos_proveedores");

        //    entity.HasOne(d => d.CodigoTdeNavigation).WithMany(p => p.EncEntradaProductos)
        //        .HasForeignKey(d => d.CodigoTde)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_enc_entrada_productos_tipos_documentos_emitir");
        //});

        //modelBuilder.Entity<Marca>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoMa);

        //    entity.ToTable("marcas");

        //    entity.Property(e => e.CodigoMa).HasColumnName("codigo_ma");
        //    entity.Property(e => e.DescripcionMa)
        //        .HasMaxLength(40)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_ma");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<Producto>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoPr);

        //    entity.ToTable("productos");

        //    entity.Property(e => e.CodigoPr).HasColumnName("codigo_pr");
        //    entity.Property(e => e.CodigoCa).HasColumnName("codigo_ca");
        //    entity.Property(e => e.CodigoMa).HasColumnName("codigo_ma");
        //    entity.Property(e => e.CodigoUm).HasColumnName("codigo_um");
        //    entity.Property(e => e.DescripcionPr)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_pr");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //    entity.Property(e => e.FechaCreacion)
        //        .HasColumnType("datetime")
        //        .HasColumnName("fecha_creacion");
        //    entity.Property(e => e.FechaModifica)
        //        .HasColumnType("datetime")
        //        .HasColumnName("fecha_modifica");
        //    entity.Property(e => e.StockMax)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("stock_max");
        //    entity.Property(e => e.StockMin)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("stock_min");

        //    entity.HasOne(d => d.CodigoCaNavigation).WithMany(p => p.Productos)
        //        .HasForeignKey(d => d.CodigoCa)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_productos_categorias");

        //    entity.HasOne(d => d.CodigoMaNavigation).WithMany(p => p.Productos)
        //        .HasForeignKey(d => d.CodigoMa)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_productos_marcas");

        //    entity.HasOne(d => d.CodigoUmNavigation).WithMany(p => p.Productos)
        //        .HasForeignKey(d => d.CodigoUm)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_productos_unidades_medidas");
        //});

        //modelBuilder.Entity<Proveedore>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoPv);

        //    entity.ToTable("proveedores");

        //    entity.Property(e => e.CodigoPv).HasColumnName("codigo_pv");
        //    entity.Property(e => e.Apellidos)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("apellidos");
        //    entity.Property(e => e.CodigoCi).HasColumnName("codigo_ci");
        //    entity.Property(e => e.CodigoRu).HasColumnName("codigo_ru");
        //    entity.Property(e => e.CodigoSx).HasColumnName("codigo_sx");
        //    entity.Property(e => e.CodigoTdpc).HasColumnName("codigo_tdpc");
        //    entity.Property(e => e.DireccionPv)
        //        .HasColumnType("text")
        //        .HasColumnName("direccion_pv");
        //    entity.Property(e => e.DocumentoPv)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("documento_pv");
        //    entity.Property(e => e.EmailPv)
        //        .HasMaxLength(150)
        //        .IsUnicode(false)
        //        .HasColumnName("email_pv");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //    entity.Property(e => e.FechaCrea)
        //        .HasColumnType("datetime")
        //        .HasColumnName("fecha_crea");
        //    entity.Property(e => e.FechaModifica)
        //        .HasColumnType("datetime")
        //        .HasColumnName("fecha_modifica");
        //    entity.Property(e => e.MovilPv)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("movil_pv");
        //    entity.Property(e => e.Nombres)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("nombres");
        //    entity.Property(e => e.ObservacionPv)
        //        .HasColumnType("text")
        //        .HasColumnName("observacion_pv");
        //    entity.Property(e => e.RazonSocialPv)
        //        .HasMaxLength(150)
        //        .IsUnicode(false)
        //        .HasColumnName("razon_social_pv");
        //    entity.Property(e => e.TelefonoPv)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("telefono_pv");

        //    entity.HasOne(d => d.CodigoCiNavigation).WithMany(p => p.Proveedores)
        //        .HasForeignKey(d => d.CodigoCi)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_proveedores_ciudades");

        //    entity.HasOne(d => d.CodigoRuNavigation).WithMany(p => p.Proveedores)
        //        .HasForeignKey(d => d.CodigoRu)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_proveedores_rubros");

        //    entity.HasOne(d => d.CodigoSxNavigation).WithMany(p => p.Proveedores)
        //        .HasForeignKey(d => d.CodigoSx)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_proveedores_sexos");

        //    entity.HasOne(d => d.CodigoTdpcNavigation).WithMany(p => p.Proveedores)
        //        .HasForeignKey(d => d.CodigoTdpc)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_proveedores_tipos_documento_pv_cl1");
        //});

        //modelBuilder.Entity<Provincia>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoProv);

        //    entity.ToTable("provincias");

        //    entity.Property(e => e.CodigoProv).HasColumnName("codigo_prov");
        //    entity.Property(e => e.DescripcionProv)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_prov");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<Rubro>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoRu);

        //    entity.ToTable("rubros");

        //    entity.Property(e => e.CodigoRu).HasColumnName("codigo_ru");
        //    entity.Property(e => e.DescripcionRu)
        //        .HasMaxLength(60)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_ru");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<Sexo>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoSx);

        //    entity.ToTable("sexos");

        //    entity.Property(e => e.CodigoSx).HasColumnName("codigo_sx");
        //    entity.Property(e => e.DescripcionSx)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_sx");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<StockProducto>(entity =>
        //{// aca cambie... antes entity.HasNoKey()
        //    entity.HasKey(x=>new { x.CodigoPr, x.CodigoAl }).HasName("PK_Stock_Producto_1"); 
        //       entity.ToTable("stock_productos");

        //    entity.Property(e => e.CodigoAl).HasColumnName("codigo_al");
        //    entity.Property(e => e.CodigoPr).HasColumnName("codigo_pr");
        //    entity.Property(e => e.PuCompra)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("pu_compra");
        //    entity.Property(e => e.StockActual)
        //        .HasColumnType("decimal(10, 2)")
        //        .HasColumnName("stock_actual");

        //    entity.HasOne(d => d.CodigoAlNavigation).WithMany(d=>d.StockProductos)
        //        .HasForeignKey(d => d.CodigoAl)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_stock_productos_almacenes");

        //    entity.HasOne(d => d.CodigoPrNavigation).WithMany(d => d.StockProductos)
        //        .HasForeignKey(d => d.CodigoPr)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_stock_productos_productos");
        //});

        //modelBuilder.Entity<TiposDocumentoPvCl>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoTdpc);

        //    entity.ToTable("tipos_documento_pv_cl");

        //    entity.Property(e => e.CodigoTdpc).HasColumnName("codigo_tdpc");
        //    entity.Property(e => e.DescripcionTdpc)
        //        .HasMaxLength(30)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_tdpc");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<TiposDocumentosEmitir>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoTde);

        //    entity.ToTable("tipos_documentos_emitir");

        //    entity.Property(e => e.CodigoTde).HasColumnName("codigo_tde");
        //    entity.Property(e => e.DescripcionTde)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_tde");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        //modelBuilder.Entity<UnidadesMedida>(entity =>
        //{
        //    entity.HasKey(e => e.CodigoUm);

        //    entity.ToTable("unidades_medidas");

        //    entity.Property(e => e.CodigoUm).HasColumnName("codigo_um");
        //    entity.Property(e => e.AbreviaturaUm)
        //        .HasMaxLength(3)
        //        .IsUnicode(false)
        //        .HasColumnName("abreviatura_um");
        //    entity.Property(e => e.DescripcionUm)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("descripcion_um");
        //    entity.Property(e => e.Estado).HasColumnName("estado");
        //});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
     
}
