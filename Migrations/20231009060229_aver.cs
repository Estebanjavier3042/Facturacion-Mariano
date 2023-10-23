using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baseDatosMariano.Migrations
{
    /// <inheritdoc />
    public partial class aver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_stock_productos",
                table: "stock_productos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock_Producto_1",
                table: "stock_productos",
                columns: new[] { "codigo_pr", "codigo_al" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock_Producto_1",
                table: "stock_productos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stock_productos",
                table: "stock_productos",
                columns: new[] { "codigo_pr", "codigo_al" });
        }
    }
}
