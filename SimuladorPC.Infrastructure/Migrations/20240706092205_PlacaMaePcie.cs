using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PlacaMaePcie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VersaoPcie",
                table: "PlacasMae",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersaoPcie",
                table: "PlacasMae");
        }
    }
}
