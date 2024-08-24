using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Sku : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "WaterCoolers",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Ssds",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Rams",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "PlacasMae",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Hds",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Gpus",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Gabinetes",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Fontes",
                newName: "Sku");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Cpus",
                newName: "Sku");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "WaterCoolers",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Ssds",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Rams",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "PlacasMae",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Hds",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Gpus",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Gabinetes",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Fontes",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Cpus",
                newName: "Modelo");
        }
    }
}
