using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Miniatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "WaterCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Ssds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "PlacasMae",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Hds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Gabinetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Fontes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miniatura",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "WaterCoolers");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Ssds");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "PlacasMae");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Hds");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Fontes");

            migrationBuilder.DropColumn(
                name: "Miniatura",
                table: "Cpus");
        }
    }
}
