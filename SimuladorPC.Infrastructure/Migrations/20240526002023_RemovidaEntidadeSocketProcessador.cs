using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovidaEntidadeSocketProcessador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterCoolerSocket");

            migrationBuilder.DropTable(
                name: "SocketProcessadores");

            migrationBuilder.RenameColumn(
                name: "SocketProcessadorId",
                table: "PlacasMae",
                newName: "SocketProcessador");

            migrationBuilder.RenameColumn(
                name: "SocketProcessadorId",
                table: "Cpus",
                newName: "SocketProcessador");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "WaterCoolers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "SocketsSuportados",
                table: "WaterCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocketsSuportados",
                table: "WaterCoolers");

            migrationBuilder.RenameColumn(
                name: "SocketProcessador",
                table: "PlacasMae",
                newName: "SocketProcessadorId");

            migrationBuilder.RenameColumn(
                name: "SocketProcessador",
                table: "Cpus",
                newName: "SocketProcessadorId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "WaterCoolers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SocketProcessadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocketProcessadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterCoolerSocket",
                columns: table => new
                {
                    SocketProcessadorId = table.Column<int>(type: "int", nullable: false),
                    WaterCoolerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolerSocket", x => new { x.SocketProcessadorId, x.WaterCoolerId });
                    table.ForeignKey(
                        name: "FK_WaterCoolerSocket_SocketProcessadores_SocketProcessadorId",
                        column: x => x.SocketProcessadorId,
                        principalTable: "SocketProcessadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterCoolerSocket_WaterCoolers_WaterCoolerId",
                        column: x => x.WaterCoolerId,
                        principalTable: "WaterCoolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaterCoolerSocket_WaterCoolerId",
                table: "WaterCoolerSocket",
                column: "WaterCoolerId");
        }
    }
}
