using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SuporteRadiador_mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TamanhoRadiador",
                table: "WaterCoolers");

            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Comprimento",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Largura",
                table: "Gabinetes");

            migrationBuilder.RenameColumn(
                name: "PesoEmKg",
                table: "Gabinetes",
                newName: "Peso_Kg");

            migrationBuilder.AddColumn<int>(
                name: "TamanhoRadiador_mm",
                table: "WaterCoolers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Comprimento",
                table: "Gpus",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Comprimento_Cm",
                table: "Gpus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Peso_Kg",
                table: "Gpus",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Altura_Cm",
                table: "Gabinetes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Comprimento_Cm",
                table: "Gabinetes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Largura_Cm",
                table: "Gabinetes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuporteRadiador_mm",
                table: "Gabinetes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TamanhoRadiador_mm",
                table: "WaterCoolers");

            migrationBuilder.DropColumn(
                name: "Comprimento",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Comprimento_Cm",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Peso_Kg",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Altura_Cm",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Comprimento_Cm",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "Largura_Cm",
                table: "Gabinetes");

            migrationBuilder.DropColumn(
                name: "SuporteRadiador_mm",
                table: "Gabinetes");

            migrationBuilder.RenameColumn(
                name: "Peso_Kg",
                table: "Gabinetes",
                newName: "PesoEmKg");

            migrationBuilder.AddColumn<string>(
                name: "TamanhoRadiador",
                table: "WaterCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Altura",
                table: "Gabinetes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Comprimento",
                table: "Gabinetes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Largura",
                table: "Gabinetes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
