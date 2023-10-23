using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baseDatosMariano.Migrations
{
    /// <inheritdoc />
    public partial class BaseDeDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "almacenes",
                columns: table => new
                {
                    codigo_al = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_al = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_almacenes", x => x.codigo_al);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    codigo_ca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_ca = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.codigo_ca);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    codigo_ma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_ma = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.codigo_ma);
                });

            migrationBuilder.CreateTable(
                name: "provincias",
                columns: table => new
                {
                    codigo_prov = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_prov = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provincias", x => x.codigo_prov);
                });

            migrationBuilder.CreateTable(
                name: "rubros",
                columns: table => new
                {
                    codigo_ru = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_ru = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rubros", x => x.codigo_ru);
                });

            migrationBuilder.CreateTable(
                name: "sexos",
                columns: table => new
                {
                    codigo_sx = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_sx = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sexos", x => x.codigo_sx);
                });

            migrationBuilder.CreateTable(
                name: "tipos_documento_pv_cl",
                columns: table => new
                {
                    codigo_tdpc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_tdpc = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_documento_pv_cl", x => x.codigo_tdpc);
                });

            migrationBuilder.CreateTable(
                name: "tipos_documentos_emitir",
                columns: table => new
                {
                    codigo_tde = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_tde = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_documentos_emitir", x => x.codigo_tde);
                });

            migrationBuilder.CreateTable(
                name: "unidades_medidas",
                columns: table => new
                {
                    codigo_um = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    abreviatura_um = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    descripcion_um = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidades_medidas", x => x.codigo_um);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    codigo_de = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_de = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    codigo_prov = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.codigo_de);
                    table.ForeignKey(
                        name: "FK_departamentos_provincias",
                        column: x => x.codigo_prov,
                        principalTable: "provincias",
                        principalColumn: "codigo_prov");
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    codigo_pr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_pr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    codigo_ma = table.Column<int>(type: "int", nullable: false),
                    codigo_um = table.Column<int>(type: "int", nullable: false),
                    codigo_ca = table.Column<int>(type: "int", nullable: false),
                    stock_min = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    stock_max = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_modifica = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.codigo_pr);
                    table.ForeignKey(
                        name: "FK_productos_categorias",
                        column: x => x.codigo_ca,
                        principalTable: "categorias",
                        principalColumn: "codigo_ca");
                    table.ForeignKey(
                        name: "FK_productos_marcas",
                        column: x => x.codigo_ma,
                        principalTable: "marcas",
                        principalColumn: "codigo_ma");
                    table.ForeignKey(
                        name: "FK_productos_unidades_medidas",
                        column: x => x.codigo_um,
                        principalTable: "unidades_medidas",
                        principalColumn: "codigo_um");
                });

            migrationBuilder.CreateTable(
                name: "ciudades",
                columns: table => new
                {
                    codigo_ci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_ci = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    codigo_de = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudades", x => x.codigo_ci);
                    table.ForeignKey(
                        name: "FK_ciudades_departamentos",
                        column: x => x.codigo_de,
                        principalTable: "departamentos",
                        principalColumn: "codigo_de");
                });

            migrationBuilder.CreateTable(
                name: "stock_productos",
                columns: table => new
                {
                    codigo_pr = table.Column<int>(type: "int", nullable: false),
                    codigo_al = table.Column<int>(type: "int", nullable: false),
                    stock_actual = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    pu_compra = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_productos", x => new { x.codigo_pr, x.codigo_al });
                    table.ForeignKey(
                        name: "FK_stock_productos_almacenes",
                        column: x => x.codigo_al,
                        principalTable: "almacenes",
                        principalColumn: "codigo_al");
                    table.ForeignKey(
                        name: "FK_stock_productos_productos",
                        column: x => x.codigo_pr,
                        principalTable: "productos",
                        principalColumn: "codigo_pr");
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    codigo_pv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_tdpc = table.Column<int>(type: "int", nullable: false),
                    documento_pv = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    razon_social_pv = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    nombres = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    apellidos = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    codigo_sx = table.Column<int>(type: "int", nullable: false),
                    codigo_ru = table.Column<int>(type: "int", nullable: false),
                    email_pv = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    telefono_pv = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    movil_pv = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    direccion_pv = table.Column<string>(type: "text", nullable: true),
                    codigo_ci = table.Column<int>(type: "int", nullable: false),
                    observacion_pv = table.Column<string>(type: "text", nullable: true),
                    fecha_crea = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_modifica = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.codigo_pv);
                    table.ForeignKey(
                        name: "FK_proveedores_ciudades",
                        column: x => x.codigo_ci,
                        principalTable: "ciudades",
                        principalColumn: "codigo_ci");
                    table.ForeignKey(
                        name: "FK_proveedores_rubros",
                        column: x => x.codigo_ru,
                        principalTable: "rubros",
                        principalColumn: "codigo_ru");
                    table.ForeignKey(
                        name: "FK_proveedores_sexos",
                        column: x => x.codigo_sx,
                        principalTable: "sexos",
                        principalColumn: "codigo_sx");
                    table.ForeignKey(
                        name: "FK_proveedores_tipos_documento_pv_cl1",
                        column: x => x.codigo_tdpc,
                        principalTable: "tipos_documento_pv_cl",
                        principalColumn: "codigo_tdpc");
                });

            migrationBuilder.CreateTable(
                name: "enc_entrada_productos",
                columns: table => new
                {
                    codigo_ep = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_tde = table.Column<int>(type: "int", nullable: false),
                    nrodocumento_ep = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    codigo_pv = table.Column<int>(type: "int", nullable: false),
                    fecha_ep = table.Column<DateTime>(type: "date", nullable: true),
                    codigo_al = table.Column<int>(type: "int", nullable: false),
                    observacion_ep = table.Column<string>(type: "text", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    iva = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    total_importe = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fecha_crea = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enc_entrada_productos", x => x.codigo_ep);
                    table.ForeignKey(
                        name: "FK_enc_entrada_productos_almacenes",
                        column: x => x.codigo_al,
                        principalTable: "almacenes",
                        principalColumn: "codigo_al");
                    table.ForeignKey(
                        name: "FK_enc_entrada_productos_proveedores",
                        column: x => x.codigo_pv,
                        principalTable: "proveedores",
                        principalColumn: "codigo_pv");
                    table.ForeignKey(
                        name: "FK_enc_entrada_productos_tipos_documentos_emitir",
                        column: x => x.codigo_tde,
                        principalTable: "tipos_documentos_emitir",
                        principalColumn: "codigo_tde");
                });

            migrationBuilder.CreateTable(
                name: "det_entrada_productos",
                columns: table => new
                {
                    codigo_ep = table.Column<int>(type: "int", nullable: false),
                    codigo_pr = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    pu_compra = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_det_entrada_productos_enc_entrada_productos",
                        column: x => x.codigo_ep,
                        principalTable: "enc_entrada_productos",
                        principalColumn: "codigo_ep");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ciudades_codigo_de",
                table: "ciudades",
                column: "codigo_de");

            migrationBuilder.CreateIndex(
                name: "IX_departamentos_codigo_prov",
                table: "departamentos",
                column: "codigo_prov");

            migrationBuilder.CreateIndex(
                name: "IX_det_entrada_productos_codigo_ep",
                table: "det_entrada_productos",
                column: "codigo_ep");

            migrationBuilder.CreateIndex(
                name: "IX_enc_entrada_productos_codigo_al",
                table: "enc_entrada_productos",
                column: "codigo_al");

            migrationBuilder.CreateIndex(
                name: "IX_enc_entrada_productos_codigo_pv",
                table: "enc_entrada_productos",
                column: "codigo_pv");

            migrationBuilder.CreateIndex(
                name: "IX_enc_entrada_productos_codigo_tde",
                table: "enc_entrada_productos",
                column: "codigo_tde");

            migrationBuilder.CreateIndex(
                name: "IX_productos_codigo_ca",
                table: "productos",
                column: "codigo_ca");

            migrationBuilder.CreateIndex(
                name: "IX_productos_codigo_ma",
                table: "productos",
                column: "codigo_ma");

            migrationBuilder.CreateIndex(
                name: "IX_productos_codigo_um",
                table: "productos",
                column: "codigo_um");

            migrationBuilder.CreateIndex(
                name: "IX_proveedores_codigo_ci",
                table: "proveedores",
                column: "codigo_ci");

            migrationBuilder.CreateIndex(
                name: "IX_proveedores_codigo_ru",
                table: "proveedores",
                column: "codigo_ru");

            migrationBuilder.CreateIndex(
                name: "IX_proveedores_codigo_sx",
                table: "proveedores",
                column: "codigo_sx");

            migrationBuilder.CreateIndex(
                name: "IX_proveedores_codigo_tdpc",
                table: "proveedores",
                column: "codigo_tdpc");

            migrationBuilder.CreateIndex(
                name: "IX_stock_productos_codigo_al",
                table: "stock_productos",
                column: "codigo_al");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "det_entrada_productos");

            migrationBuilder.DropTable(
                name: "stock_productos");

            migrationBuilder.DropTable(
                name: "enc_entrada_productos");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "almacenes");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "tipos_documentos_emitir");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "unidades_medidas");

            migrationBuilder.DropTable(
                name: "ciudades");

            migrationBuilder.DropTable(
                name: "rubros");

            migrationBuilder.DropTable(
                name: "sexos");

            migrationBuilder.DropTable(
                name: "tipos_documento_pv_cl");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "provincias");
        }
    }
}
