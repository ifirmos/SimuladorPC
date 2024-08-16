using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TipoMemoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacasMae_TiposMemoria_TipoMemoriaId",
                table: "PlacasMae");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                table: "Rams");

            migrationBuilder.DropTable(
                name: "TiposMemoria");

            migrationBuilder.DropIndex(
                name: "IX_Rams_TipoMemoriaId",
                table: "Rams");

            migrationBuilder.DropIndex(
                name: "IX_PlacasMae_TipoMemoriaId",
                table: "PlacasMae");

            migrationBuilder.RenameColumn(
                name: "TipoMemoriaId",
                table: "Rams",
                newName: "TipoMemoria");

            migrationBuilder.AddColumn<int>(
                name: "TipoMemoria",
                table: "PlacasMae",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoMemoria",
                table: "PlacasMae");

            migrationBuilder.RenameColumn(
                name: "TipoMemoria",
                table: "Rams",
                newName: "TipoMemoriaId");

            migrationBuilder.CreateTable(
                name: "TiposMemoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMemoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rams_TipoMemoriaId",
                table: "Rams",
                column: "TipoMemoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_TipoMemoriaId",
                table: "PlacasMae",
                column: "TipoMemoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacasMae_TiposMemoria_TipoMemoriaId",
                table: "PlacasMae",
                column: "TipoMemoriaId",
                principalTable: "TiposMemoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                table: "Rams",
                column: "TipoMemoriaId",
                principalTable: "TiposMemoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
