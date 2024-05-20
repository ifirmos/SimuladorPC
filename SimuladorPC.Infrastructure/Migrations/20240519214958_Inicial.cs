using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chipsets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chipsets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fontes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    Modular = table.Column<bool>(type: "bit", nullable: false),
                    PFCAtivo = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fontes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gabinetes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Largura = table.Column<double>(type: "float", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    PesoEmKg = table.Column<float>(type: "real", nullable: false),
                    BaiasInternas = table.Column<int>(type: "int", nullable: false),
                    BaiasExternas = table.Column<int>(type: "int", nullable: false),
                    CorIluminacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemJanela = table.Column<bool>(type: "bit", nullable: false),
                    CorGabinete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gabinetes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtdMemoriaMb = table.Column<int>(type: "int", nullable: false),
                    PortasDisplayPort = table.Column<int>(type: "int", nullable: false),
                    PortasHdmi = table.Column<int>(type: "int", nullable: false),
                    QtdCoolers = table.Column<int>(type: "int", nullable: false),
                    PotenciaRecomendadaEmWatts = table.Column<int>(type: "int", nullable: false),
                    FrequenciaBaseMhz = table.Column<int>(type: "int", nullable: false),
                    FrequenciaMaxMhz = table.Column<int>(type: "int", nullable: false),
                    TecnologiasSuportadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacidadeGb = table.Column<int>(type: "int", nullable: false),
                    Velocidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocketProcessadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocketProcessadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Versao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ssds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Formato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacidadeGb = table.Column<int>(type: "int", nullable: false),
                    VelocidadeLeituraEmMbps = table.Column<int>(type: "int", nullable: false),
                    VelocidadeEscritaEmMbps = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ssds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TamanhoPlacaMae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tamanho = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamanhoPlacaMae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposIluminacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIluminacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorFixa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIluminacao", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "WaterCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TamanhoRadiador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeFans = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinhaProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TecnologiaFabricacao = table.Column<int>(type: "int", nullable: false),
                    CacheL1 = table.Column<int>(type: "int", nullable: false),
                    CacheL2 = table.Column<int>(type: "int", nullable: false),
                    CacheL3 = table.Column<int>(type: "int", nullable: false),
                    SuporteMultithreading = table.Column<bool>(type: "bit", nullable: false),
                    ConjuntoInstrucoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequenciaBoostMhz = table.Column<int>(type: "int", nullable: false),
                    ConsumoEnergia = table.Column<int>(type: "int", nullable: false),
                    GraficosIntegrados = table.Column<bool>(type: "bit", nullable: false),
                    TemperaturaMaxima = table.Column<int>(type: "int", nullable: false),
                    SuporteMemoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCanaisMemoria = table.Column<int>(type: "int", nullable: false),
                    Plataforma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PcieVersao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PcieLanes = table.Column<int>(type: "int", nullable: false),
                    Nucleos = table.Column<int>(type: "int", nullable: false),
                    Threads = table.Column<int>(type: "int", nullable: false),
                    FrequenciaBaseMhz = table.Column<int>(type: "int", nullable: false),
                    FrequenciaMaximaMhz = table.Column<int>(type: "int", nullable: false),
                    SocketProcessadorId = table.Column<int>(type: "int", nullable: false),
                    Tdp = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cpus_SocketProcessadores_SocketProcessadorId",
                        column: x => x.SocketProcessadorId,
                        principalTable: "SocketProcessadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequisitosHardware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    NivelDesempenho = table.Column<int>(type: "int", nullable: false),
                    TecnologiasRequeridas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpuImportancia = table.Column<double>(type: "float", nullable: false),
                    GpuImportancia = table.Column<double>(type: "float", nullable: false),
                    RamImportancia = table.Column<double>(type: "float", nullable: false),
                    ArmazenamentoImportancia = table.Column<double>(type: "float", nullable: false),
                    MinimoNucleosCpu = table.Column<int>(type: "int", nullable: false),
                    MinimoClockGhzCpu = table.Column<int>(type: "int", nullable: false),
                    MinimoClockGhzGpu = table.Column<int>(type: "int", nullable: false),
                    MinimoVRamGpuGb = table.Column<int>(type: "int", nullable: false),
                    MinimoRamGb = table.Column<int>(type: "int", nullable: false),
                    MinimoArmazenamentoGb = table.Column<int>(type: "int", nullable: false),
                    TipoArmazenamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitosHardware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequisitosHardware_Softwares_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacasMae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocketProcessadorId = table.Column<int>(type: "int", nullable: false),
                    ChipsetId = table.Column<int>(type: "int", nullable: false),
                    TamanhoPlacaMaeId = table.Column<int>(type: "int", nullable: false),
                    TipoMemoriaId = table.Column<int>(type: "int", nullable: false),
                    SlotsMemoria = table.Column<int>(type: "int", nullable: false),
                    MaxMemoriaSuportadaGb = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacasMae", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacasMae_Chipsets_ChipsetId",
                        column: x => x.ChipsetId,
                        principalTable: "Chipsets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlacasMae_SocketProcessadores_SocketProcessadorId",
                        column: x => x.SocketProcessadorId,
                        principalTable: "SocketProcessadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlacasMae_TamanhoPlacaMae_TamanhoPlacaMaeId",
                        column: x => x.TamanhoPlacaMaeId,
                        principalTable: "TamanhoPlacaMae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlacasMae_TiposMemoria_TipoMemoriaId",
                        column: x => x.TipoMemoriaId,
                        principalTable: "TiposMemoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacidadeGb = table.Column<int>(type: "int", nullable: false),
                    ClockBaseMhz = table.Column<int>(type: "int", nullable: false),
                    ClockMaximoOverclockMhz = table.Column<int>(type: "int", nullable: false),
                    Rgb = table.Column<bool>(type: "bit", nullable: false),
                    TipoMemoriaId = table.Column<int>(type: "int", nullable: false),
                    Latencia = table.Column<int>(type: "int", nullable: false),
                    Voltagem = table.Column<double>(type: "float", nullable: false),
                    Ecc = table.Column<bool>(type: "bit", nullable: false),
                    XmpSuportado = table.Column<bool>(type: "bit", nullable: false),
                    Modulos = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rams_TiposMemoria_TipoMemoriaId",
                        column: x => x.TipoMemoriaId,
                        principalTable: "TiposMemoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chipsets_Modelo",
                table: "Chipsets",
                column: "Modelo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_SocketProcessadorId",
                table: "Cpus",
                column: "SocketProcessadorId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_ChipsetId",
                table: "PlacasMae",
                column: "ChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_SocketProcessadorId",
                table: "PlacasMae",
                column: "SocketProcessadorId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_TamanhoPlacaMaeId",
                table: "PlacasMae",
                column: "TamanhoPlacaMaeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_TipoMemoriaId",
                table: "PlacasMae",
                column: "TipoMemoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_TipoMemoriaId",
                table: "Rams",
                column: "TipoMemoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitosHardware_SoftwareId",
                table: "RequisitosHardware",
                column: "SoftwareId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Fontes");

            migrationBuilder.DropTable(
                name: "Gabinetes");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "Hds");

            migrationBuilder.DropTable(
                name: "PlacasMae");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "RequisitosHardware");

            migrationBuilder.DropTable(
                name: "Ssds");

            migrationBuilder.DropTable(
                name: "TiposIluminacao");

            migrationBuilder.DropTable(
                name: "WaterCoolers");

            migrationBuilder.DropTable(
                name: "Chipsets");

            migrationBuilder.DropTable(
                name: "SocketProcessadores");

            migrationBuilder.DropTable(
                name: "TamanhoPlacaMae");

            migrationBuilder.DropTable(
                name: "TiposMemoria");

            migrationBuilder.DropTable(
                name: "Softwares");
        }
    }
}
