using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TipoMemoriaSemId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TamanhoPlacaMaeId",
                table: "PlacasMae");

            migrationBuilder.DropColumn(
                name: "TipoMemoriaId",
                table: "PlacasMae");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TamanhoPlacaMaeId",
                table: "PlacasMae",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoMemoriaId",
                table: "PlacasMae",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
