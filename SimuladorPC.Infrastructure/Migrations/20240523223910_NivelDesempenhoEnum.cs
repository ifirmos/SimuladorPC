using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NivelDesempenhoEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pontuacao3DMark",
                table: "RequisitosHardware",
                newName: "PontuacaoPassMarkG3D");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PontuacaoPassMarkG3D",
                table: "RequisitosHardware",
                newName: "Pontuacao3DMark");
        }
    }
}
