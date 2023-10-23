using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baseDatosMariano.Migrations
{
    /// <inheritdoc />
    public partial class aver1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_det_entrada_productos_codigo_ep",
                table: "det_entrada_productos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_det_entrada_productos",
                table: "det_entrada_productos",
                columns: new[] { "codigo_ep", "codigo_pr" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_det_entrada_productos",
                table: "det_entrada_productos");

            migrationBuilder.CreateIndex(
                name: "IX_det_entrada_productos_codigo_ep",
                table: "det_entrada_productos",
                column: "codigo_ep");
        }
    }
}
