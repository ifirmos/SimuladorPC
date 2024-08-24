using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImagensComponentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "WaterCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Ssds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "PlacasMae",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Hds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Gabinetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Fontes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "WaterCoolers");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Ssds");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "PlacasMae");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Hds");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Fontes");

            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "Cpus");
        }
    }
}
