using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CpuTipoMemoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CacheL1",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CacheL2",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CacheL3",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TecnologiaFabricacao",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoMemoria",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CacheL1",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "CacheL2",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "CacheL3",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "TecnologiaFabricacao",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "TipoMemoria",
                table: "Cpus");
        }
    }
}
