using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cpusemsuportememoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "SuporteMemoria",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "TecnologiaFabricacao",
                table: "Cpus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "SuporteMemoria",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TecnologiaFabricacao",
                table: "Cpus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
