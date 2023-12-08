using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerGearAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoPerifericoMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Periferico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Periferico_MarcaId",
                table: "Periferico",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Periferico_Marca_MarcaId",
                table: "Periferico",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Periferico_Marca_MarcaId",
                table: "Periferico");

            migrationBuilder.DropIndex(
                name: "IX_Periferico_MarcaId",
                table: "Periferico");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Periferico");
        }
    }
}
