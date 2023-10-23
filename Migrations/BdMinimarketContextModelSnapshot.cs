﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using baseDatosMariano;

#nullable disable

namespace baseDatosMariano.Migrations
{
    [DbContext(typeof(BdMinimarketContext))]
    partial class BdMinimarketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("baseDatosMariano.Entidades.Almacene", b =>
                {
                    b.Property<int>("CodigoAl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_al");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoAl"));

                    b.Property<string>("DescripcionAl")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripcion_al");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoAl");

                    b.ToTable("almacenes", (string)null);

                    b.HasData(
                        new
                        {
                            CodigoAl = 2,
                            DescripcionAl = "SucAlvear",
                            Estado = true
                        },
                        new
                        {
                            CodigoAl = 3,
                            DescripcionAl = "SucAlvarez",
                            Estado = true
                        },
                        new
                        {
                            CodigoAl = 4,
                            DescripcionAl = "SucRoldan",
                            Estado = true
                        },
                        new
                        {
                            CodigoAl = 5,
                            DescripcionAl = "SucFunes",
                            Estado = true
                        });
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Categoria", b =>
                {
                    b.Property<int>("CodigoCa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_ca");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoCa"));

                    b.Property<string>("DescripcionCa")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("descripcion_ca");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoCa");

                    b.ToTable("categorias", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Ciudade", b =>
                {
                    b.Property<int>("CodigoCi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_ci");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoCi"));

                    b.Property<int>("CodigoDe")
                        .HasColumnType("int")
                        .HasColumnName("codigo_de");

                    b.Property<string>("DescripcionCi")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcion_ci");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoCi");

                    b.HasIndex("CodigoDe");

                    b.ToTable("ciudades", (string)null);

                    b.HasData(
                        new
                        {
                            CodigoCi = 7,
                            CodigoDe = 1,
                            DescripcionCi = "Alvear",
                            Estado = true
                        },
                        new
                        {
                            CodigoCi = 8,
                            CodigoDe = 1,
                            DescripcionCi = "Alvarez",
                            Estado = true
                        },
                        new
                        {
                            CodigoCi = 9,
                            CodigoDe = 1,
                            DescripcionCi = "Acebal",
                            Estado = true
                        },
                        new
                        {
                            CodigoCi = 10,
                            CodigoDe = 1,
                            DescripcionCi = "Casilda",
                            Estado = true
                        });
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Departamento", b =>
                {
                    b.Property<int>("CodigoDe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_de");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoDe"));

                    b.Property<int>("CodigoProv")
                        .HasColumnType("int")
                        .HasColumnName("codigo_prov");

                    b.Property<string>("DescripcionDe")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcion_de");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoDe");

                    b.HasIndex("CodigoProv");

                    b.ToTable("departamentos", (string)null);

                    b.HasData(
                        new
                        {
                            CodigoDe = 2,
                            CodigoProv = 1,
                            DescripcionDe = "Constitucion",
                            Estado = true
                        },
                        new
                        {
                            CodigoDe = 3,
                            CodigoProv = 1,
                            DescripcionDe = "Iriondo",
                            Estado = true
                        },
                        new
                        {
                            CodigoDe = 4,
                            CodigoProv = 1,
                            DescripcionDe = "San Lorenzo",
                            Estado = true
                        },
                        new
                        {
                            CodigoDe = 5,
                            CodigoProv = 1,
                            DescripcionDe = "San Jeronimo",
                            Estado = true
                        });
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.DetEntradaProducto", b =>
                {
                    b.Property<int>("CodigoEp")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ep");

                    b.Property<int>("CodigoPr")
                        .HasColumnType("int")
                        .HasColumnName("codigo_pr");

                    b.Property<decimal?>("Cantidad")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("cantidad");

                    b.Property<decimal?>("PuCompra")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("pu_compra");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("total");

                    b.HasKey("CodigoEp", "CodigoPr");

                    b.ToTable("det_entrada_productos", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.EncEntradaProducto", b =>
                {
                    b.Property<int>("CodigoEp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_ep");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoEp"));

                    b.Property<int>("CodigoAl")
                        .HasColumnType("int")
                        .HasColumnName("codigo_al");

                    b.Property<int>("CodigoPv")
                        .HasColumnType("int")
                        .HasColumnName("codigo_pv");

                    b.Property<int>("CodigoTde")
                        .HasColumnType("int")
                        .HasColumnName("codigo_tde");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<DateTime?>("FechaCrea")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_crea");

                    b.Property<DateTime?>("FechaEp")
                        .HasColumnType("date")
                        .HasColumnName("fecha_ep");

                    b.Property<decimal?>("Iva")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("iva");

                    b.Property<string>("NrodocumentoEp")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nrodocumento_ep");

                    b.Property<string>("ObservacionEp")
                        .HasColumnType("text")
                        .HasColumnName("observacion_ep");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("subtotal");

                    b.Property<decimal?>("TotalImporte")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("total_importe");

                    b.HasKey("CodigoEp");

                    b.HasIndex("CodigoAl");

                    b.HasIndex("CodigoPv");

                    b.HasIndex("CodigoTde");

                    b.ToTable("enc_entrada_productos", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Marca", b =>
                {
                    b.Property<int>("CodigoMa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_ma");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoMa"));

                    b.Property<string>("DescripcionMa")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("descripcion_ma");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoMa");

                    b.ToTable("marcas", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Producto", b =>
                {
                    b.Property<int>("CodigoPr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_pr");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoPr"));

                    b.Property<int>("CodigoCa")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ca");

                    b.Property<int>("CodigoMa")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ma");

                    b.Property<int>("CodigoUm")
                        .HasColumnType("int")
                        .HasColumnName("codigo_um");

                    b.Property<string>("DescripcionPr")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcion_pr");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime?>("FechaModifica")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_modifica");

                    b.Property<decimal?>("StockMax")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("stock_max");

                    b.Property<decimal?>("StockMin")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("stock_min");

                    b.HasKey("CodigoPr");

                    b.HasIndex("CodigoCa");

                    b.HasIndex("CodigoMa");

                    b.HasIndex("CodigoUm");

                    b.ToTable("productos", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Proveedore", b =>
                {
                    b.Property<int>("CodigoPv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_pv");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoPv"));

                    b.Property<string>("Apellidos")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("apellidos");

                    b.Property<int>("CodigoCi")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ci");

                    b.Property<int>("CodigoRu")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ru");

                    b.Property<int>("CodigoSx")
                        .HasColumnType("int")
                        .HasColumnName("codigo_sx");

                    b.Property<int>("CodigoTdpc")
                        .HasColumnType("int")
                        .HasColumnName("codigo_tdpc");

                    b.Property<string>("DireccionPv")
                        .HasColumnType("text")
                        .HasColumnName("direccion_pv");

                    b.Property<string>("DocumentoPv")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("documento_pv");

                    b.Property<string>("EmailPv")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email_pv");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<DateTime?>("FechaCrea")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_crea");

                    b.Property<DateTime?>("FechaModifica")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_modifica");

                    b.Property<string>("MovilPv")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("movil_pv");

                    b.Property<string>("Nombres")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombres");

                    b.Property<string>("ObservacionPv")
                        .HasColumnType("text")
                        .HasColumnName("observacion_pv");

                    b.Property<string>("RazonSocialPv")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("razon_social_pv");

                    b.Property<string>("TelefonoPv")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefono_pv");

                    b.HasKey("CodigoPv");

                    b.HasIndex("CodigoCi");

                    b.HasIndex("CodigoRu");

                    b.HasIndex("CodigoSx");

                    b.HasIndex("CodigoTdpc");

                    b.ToTable("proveedores", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Provincia", b =>
                {
                    b.Property<int>("CodigoProv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_prov");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoProv"));

                    b.Property<string>("DescripcionProv")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcion_prov");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoProv");

                    b.ToTable("provincias", (string)null);

                    b.HasData(
                        new
                        {
                            CodigoProv = 2,
                            DescripcionProv = "Buenos Aires",
                            Estado = true
                        },
                        new
                        {
                            CodigoProv = 3,
                            DescripcionProv = "Cordoba",
                            Estado = true
                        },
                        new
                        {
                            CodigoProv = 4,
                            DescripcionProv = "Entre Rios",
                            Estado = true
                        },
                        new
                        {
                            CodigoProv = 5,
                            DescripcionProv = "Mendoza",
                            Estado = true
                        },
                        new
                        {
                            CodigoProv = 6,
                            DescripcionProv = "Corrientes",
                            Estado = true
                        });
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Rubro", b =>
                {
                    b.Property<int>("CodigoRu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_ru");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoRu"));

                    b.Property<string>("DescripcionRu")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("descripcion_ru");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoRu");

                    b.ToTable("rubros", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Sexo", b =>
                {
                    b.Property<int>("CodigoSx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_sx");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoSx"));

                    b.Property<string>("DescripcionSx")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("descripcion_sx");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoSx");

                    b.ToTable("sexos", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.StockProducto", b =>
                {
                    b.Property<int>("CodigoPr")
                        .HasColumnType("int")
                        .HasColumnName("codigo_pr");

                    b.Property<int>("CodigoAl")
                        .HasColumnType("int")
                        .HasColumnName("codigo_al");

                    b.Property<decimal?>("PuCompra")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("pu_compra");

                    b.Property<decimal?>("StockActual")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("stock_actual");

                    b.HasKey("CodigoPr", "CodigoAl")
                        .HasName("PK_Stock_Producto_1");

                    b.HasIndex("CodigoAl");

                    b.ToTable("stock_productos", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.TiposDocumentoPvCl", b =>
                {
                    b.Property<int>("CodigoTdpc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_tdpc");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoTdpc"));

                    b.Property<string>("DescripcionTdpc")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("descripcion_tdpc");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoTdpc");

                    b.ToTable("tipos_documento_pv_cl", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.TiposDocumentosEmitir", b =>
                {
                    b.Property<int>("CodigoTde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_tde");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoTde"));

                    b.Property<string>("DescripcionTde")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripcion_tde");

                    b.Property<bool?>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoTde");

                    b.ToTable("tipos_documentos_emitir", (string)null);
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.UnidadesMedida", b =>
                {
                    b.Property<int>("CodigoUm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codigo_um");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoUm"));

                    b.Property<string>("AbreviaturaUm")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("abreviatura_um");

                    b.Property<string>("DescripcionUm")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("descripcion_um");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.HasKey("CodigoUm");

                    b.ToTable("unidades_medidas", (string)null);

                    b.HasData(
                        new
                        {
                            CodigoUm = 2,
                            AbreviaturaUm = "Lts",
                            DescripcionUm = "Litros",
                            Estado = true
                        },
                        new
                        {
                            CodigoUm = 3,
                            AbreviaturaUm = "m",
                            DescripcionUm = "Metros",
                            Estado = true
                        });
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Ciudade", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.Departamento", "CodigoDeNavigation")
                        .WithMany("Ciudades")
                        .HasForeignKey("CodigoDe")
                        .IsRequired()
                        .HasConstraintName("FK_ciudades_departamentos");

                    b.Navigation("CodigoDeNavigation");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Departamento", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.Provincia", "CodigoProvNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("CodigoProv")
                        .IsRequired()
                        .HasConstraintName("FK_departamentos_provincias");

                    b.Navigation("CodigoProvNavigation");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.DetEntradaProducto", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.EncEntradaProducto", "EncEntradaProducto")
                        .WithMany("DetEntradaProductos")
                        .HasForeignKey("CodigoEp")
                        .IsRequired()
                        .HasConstraintName("FK_det_entrada_productos_enc_entrada_productos");

                    b.Navigation("EncEntradaProducto");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.EncEntradaProducto", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.Almacene", "CodigoAlNavigation")
                        .WithMany("EncEntradaProductos")
                        .HasForeignKey("CodigoAl")
                        .IsRequired()
                        .HasConstraintName("FK_enc_entrada_productos_almacenes");

                    b.HasOne("baseDatosMariano.Entidades.Proveedore", "CodigoPvNavigation")
                        .WithMany("EncEntradaProductos")
                        .HasForeignKey("CodigoPv")
                        .IsRequired()
                        .HasConstraintName("FK_enc_entrada_productos_proveedores");

                    b.HasOne("baseDatosMariano.Entidades.TiposDocumentosEmitir", "CodigoTdeNavigation")
                        .WithMany("EncEntradaProductos")
                        .HasForeignKey("CodigoTde")
                        .IsRequired()
                        .HasConstraintName("FK_enc_entrada_productos_tipos_documentos_emitir");

                    b.Navigation("CodigoAlNavigation");

                    b.Navigation("CodigoPvNavigation");

                    b.Navigation("CodigoTdeNavigation");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Producto", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.Categoria", "CodigoCaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("CodigoCa")
                        .IsRequired()
                        .HasConstraintName("FK_productos_categorias");

                    b.HasOne("baseDatosMariano.Entidades.Marca", "CodigoMaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("CodigoMa")
                        .IsRequired()
                        .HasConstraintName("FK_productos_marcas");

                    b.HasOne("baseDatosMariano.Entidades.UnidadesMedida", "CodigoUmNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("CodigoUm")
                        .IsRequired()
                        .HasConstraintName("FK_productos_unidades_medidas");

                    b.Navigation("CodigoCaNavigation");

                    b.Navigation("CodigoMaNavigation");

                    b.Navigation("CodigoUmNavigation");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Proveedore", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.Ciudade", "CodigoCiNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("CodigoCi")
                        .IsRequired()
                        .HasConstraintName("FK_proveedores_ciudades");

                    b.HasOne("baseDatosMariano.Entidades.Rubro", "CodigoRuNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("CodigoRu")
                        .IsRequired()
                        .HasConstraintName("FK_proveedores_rubros");

                    b.HasOne("baseDatosMariano.Entidades.Sexo", "CodigoSxNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("CodigoSx")
                        .IsRequired()
                        .HasConstraintName("FK_proveedores_sexos");

                    b.HasOne("baseDatosMariano.Entidades.TiposDocumentoPvCl", "CodigoTdpcNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("CodigoTdpc")
                        .IsRequired()
                        .HasConstraintName("FK_proveedores_tipos_documento_pv_cl1");

                    b.Navigation("CodigoCiNavigation");

                    b.Navigation("CodigoRuNavigation");

                    b.Navigation("CodigoSxNavigation");

                    b.Navigation("CodigoTdpcNavigation");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.StockProducto", b =>
                {
                    b.HasOne("baseDatosMariano.Entidades.Almacene", "CodigoAlNavigation")
                        .WithMany("StockProductos")
                        .HasForeignKey("CodigoAl")
                        .IsRequired()
                        .HasConstraintName("FK_stock_productos_almacenes");

                    b.HasOne("baseDatosMariano.Entidades.Producto", "CodigoPrNavigation")
                        .WithMany("StockProductos")
                        .HasForeignKey("CodigoPr")
                        .IsRequired()
                        .HasConstraintName("FK_stock_productos_productos");

                    b.Navigation("CodigoAlNavigation");

                    b.Navigation("CodigoPrNavigation");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Almacene", b =>
                {
                    b.Navigation("EncEntradaProductos");

                    b.Navigation("StockProductos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Ciudade", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.EncEntradaProducto", b =>
                {
                    b.Navigation("DetEntradaProductos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Producto", b =>
                {
                    b.Navigation("StockProductos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Proveedore", b =>
                {
                    b.Navigation("EncEntradaProductos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Provincia", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Rubro", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.Sexo", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.TiposDocumentoPvCl", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.TiposDocumentosEmitir", b =>
                {
                    b.Navigation("EncEntradaProductos");
                });

            modelBuilder.Entity("baseDatosMariano.Entidades.UnidadesMedida", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
