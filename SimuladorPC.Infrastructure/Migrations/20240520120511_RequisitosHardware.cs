using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RequisitosHardware : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinimoClockGhzGpu",
                table: "RequisitosHardware",
                newName: "MinimoClockGpuMhz");

            migrationBuilder.RenameColumn(
                name: "MinimoClockGhzCpu",
                table: "RequisitosHardware",
                newName: "MinimoClockCpuMhz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinimoClockGpuMhz",
                table: "RequisitosHardware",
                newName: "MinimoClockGhzGpu");

            migrationBuilder.RenameColumn(
                name: "MinimoClockCpuMhz",
                table: "RequisitosHardware",
                newName: "MinimoClockGhzCpu");
        }
    }
}
