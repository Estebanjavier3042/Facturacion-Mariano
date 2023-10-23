using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace baseDatosMariano.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "almacenes",
                columns: new[] { "codigo_al", "descripcion_al", "estado" },
                values: new object[,]
                {
                    { 2, "SucAlvear", true },
                    { 3, "SucAlvarez", true },
                    { 4, "SucRoldan", true },
                    { 5, "SucFunes", true }
                });

            migrationBuilder.InsertData(
                table: "ciudades",
                columns: new[] { "codigo_ci", "codigo_de", "descripcion_ci", "estado" },
                values: new object[,]
                {
                    { 7, 1, "Alvear", true },
                    { 8, 1, "Alvarez", true },
                    { 9, 1, "Acebal", true },
                    { 10, 1, "Casilda", true }
                });

            migrationBuilder.InsertData(
                table: "departamentos",
                columns: new[] { "codigo_de", "codigo_prov", "descripcion_de", "estado" },
                values: new object[,]
                {
                    { 2, 1, "Constitucion", true },
                    { 3, 1, "Iriondo", true },
                    { 4, 1, "San Lorenzo", true },
                    { 5, 1, "San Jeronimo", true }
                });

            migrationBuilder.InsertData(
                table: "provincias",
                columns: new[] { "codigo_prov", "descripcion_prov", "estado" },
                values: new object[,]
                {
                    { 2, "Buenos Aires", true },
                    { 3, "Cordoba", true },
                    { 4, "Entre Rios", true },
                    { 5, "Mendoza", true },
                    { 6, "Corrientes", true }
                });

            migrationBuilder.InsertData(
                table: "unidades_medidas",
                columns: new[] { "codigo_um", "abreviatura_um", "descripcion_um", "estado" },
                values: new object[,]
                {
                    { 2, "Lts", "Litros", true },
                    { 3, "m", "Metros", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "almacenes",
                keyColumn: "codigo_al",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "almacenes",
                keyColumn: "codigo_al",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "almacenes",
                keyColumn: "codigo_al",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "almacenes",
                keyColumn: "codigo_al",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ciudades",
                keyColumn: "codigo_ci",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ciudades",
                keyColumn: "codigo_ci",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ciudades",
                keyColumn: "codigo_ci",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ciudades",
                keyColumn: "codigo_ci",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "departamentos",
                keyColumn: "codigo_de",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "departamentos",
                keyColumn: "codigo_de",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "departamentos",
                keyColumn: "codigo_de",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "departamentos",
                keyColumn: "codigo_de",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "provincias",
                keyColumn: "codigo_prov",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "provincias",
                keyColumn: "codigo_prov",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "provincias",
                keyColumn: "codigo_prov",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "provincias",
                keyColumn: "codigo_prov",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "provincias",
                keyColumn: "codigo_prov",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "unidades_medidas",
                keyColumn: "codigo_um",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "unidades_medidas",
                keyColumn: "codigo_um",
                keyValue: 3);
        }
    }
}
