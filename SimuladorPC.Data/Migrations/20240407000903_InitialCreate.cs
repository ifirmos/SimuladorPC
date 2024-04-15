using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gabinetes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Largura = table.Column<double>(type: "float", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    BaiasInternas = table.Column<int>(type: "int", nullable: false),
                    BaiasExternas = table.Column<int>(type: "int", nullable: false),
                    SuportePlacaMae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iluminacao_TemIluminacao = table.Column<bool>(type: "bit", nullable: false),
                    Iluminacao_IsRgb = table.Column<bool>(type: "bit", nullable: false),
                    Iluminacao_IsArgb = table.Column<bool>(type: "bit", nullable: false),
                    Iluminacao_CorFixa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemJanela = table.Column<bool>(type: "bit", nullable: false),
                    TemFiltrosDePoeira = table.Column<bool>(type: "bit", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gabinetes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterCoolers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TamanhoRadiador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeFans = table.Column<int>(type: "int", nullable: false),
                    Iluminacao_TemIluminacao = table.Column<bool>(type: "bit", nullable: true),
                    Iluminacao_IsRgb = table.Column<bool>(type: "bit", nullable: true),
                    Iluminacao_IsArgb = table.Column<bool>(type: "bit", nullable: true),
                    Iluminacao_CorFixa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocketsCompativeis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gabinetes");

            migrationBuilder.DropTable(
                name: "WaterCoolers");
        }
    }
}
