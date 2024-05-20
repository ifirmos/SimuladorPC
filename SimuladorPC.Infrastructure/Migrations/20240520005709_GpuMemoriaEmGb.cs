using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GpuMemoriaEmGb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                table: "Rams");

            migrationBuilder.RenameColumn(
                name: "QtdMemoriaMb",
                table: "Gpus",
                newName: "QtdMemoriaEmGb");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                table: "Rams",
                column: "TipoMemoriaId",
                principalTable: "TiposMemoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                table: "Rams");

            migrationBuilder.RenameColumn(
                name: "QtdMemoriaEmGb",
                table: "Gpus",
                newName: "QtdMemoriaMb");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Rams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Rams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Rams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                table: "Rams",
                column: "TipoMemoriaId",
                principalTable: "TiposMemoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
