using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TamanhoPlacaMae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TamanhoPlacaMae",
                table: "PlacasMae",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_ChipsetId",
                table: "PlacasMae",
                column: "ChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_TipoMemoriaId",
                table: "PlacasMae",
                column: "TipoMemoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacasMae_Chipsets_ChipsetId",
                table: "PlacasMae",
                column: "ChipsetId",
                principalTable: "Chipsets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacasMae_TiposMemoria_TipoMemoriaId",
                table: "PlacasMae",
                column: "TipoMemoriaId",
                principalTable: "TiposMemoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacasMae_Chipsets_ChipsetId",
                table: "PlacasMae");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacasMae_TiposMemoria_TipoMemoriaId",
                table: "PlacasMae");

            migrationBuilder.DropIndex(
                name: "IX_PlacasMae_ChipsetId",
                table: "PlacasMae");

            migrationBuilder.DropIndex(
                name: "IX_PlacasMae_TipoMemoriaId",
                table: "PlacasMae");

            migrationBuilder.DropColumn(
                name: "TamanhoPlacaMae",
                table: "PlacasMae");
        }
    }
}
