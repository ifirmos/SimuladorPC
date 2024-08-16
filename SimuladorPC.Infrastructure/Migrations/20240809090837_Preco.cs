using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Preco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "WaterCoolers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Ssds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Rams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "PlacasMae",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Hds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Gpus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Gabinetes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Fontes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Preco",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "WaterCoolers");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Ssds");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "PlacasMae");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Hds");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Fontes");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Cpus");
        }
    }
}
