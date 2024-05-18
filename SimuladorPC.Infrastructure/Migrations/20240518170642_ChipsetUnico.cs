using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChipsetUnico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Chipsets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Chipsets_Modelo",
                table: "Chipsets",
                column: "Modelo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chipsets_Modelo",
                table: "Chipsets");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Chipsets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
