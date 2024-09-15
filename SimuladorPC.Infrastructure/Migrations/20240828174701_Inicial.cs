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
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
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
                name: "Chipsets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chipsets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chipsets_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    VersaoPcie = table.Column<int>(type: "int", nullable: false),
                    PcieLanes = table.Column<int>(type: "int", nullable: false),
                    Nucleos = table.Column<int>(type: "int", nullable: false),
                    Threads = table.Column<int>(type: "int", nullable: false),
                    FrequenciaBaseMhz = table.Column<int>(type: "int", nullable: false),
                    FrequenciaMaximaMhz = table.Column<int>(type: "int", nullable: false),
                    SocketProcessador = table.Column<int>(type: "int", nullable: false),
                    PontuacaoCpuMark = table.Column<int>(type: "int", nullable: false),
                    Tdp = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cpus_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fontes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fontes_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gabinetes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura_Cm = table.Column<int>(type: "int", nullable: false),
                    Largura_Cm = table.Column<int>(type: "int", nullable: false),
                    Comprimento_Cm = table.Column<int>(type: "int", nullable: false),
                    SuporteRadiador_mm = table.Column<int>(type: "int", nullable: false),
                    Peso_Kg = table.Column<float>(type: "real", nullable: false),
                    BaiasInternas = table.Column<int>(type: "int", nullable: false),
                    BaiasExternas = table.Column<int>(type: "int", nullable: false),
                    CorIluminacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemJanela = table.Column<bool>(type: "bit", nullable: false),
                    CorGabinete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gabinetes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gabinetes_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comprimento_Cm = table.Column<int>(type: "int", nullable: false),
                    Peso_Kg = table.Column<float>(type: "real", nullable: false),
                    QtdMemoriaEmGb = table.Column<int>(type: "int", nullable: false),
                    PortasDisplayPort = table.Column<int>(type: "int", nullable: false),
                    PortasHdmi = table.Column<int>(type: "int", nullable: false),
                    QtdCoolers = table.Column<int>(type: "int", nullable: false),
                    PotenciaRecomendadaEmWatts = table.Column<int>(type: "int", nullable: false),
                    FrequenciaBaseMhz = table.Column<int>(type: "int", nullable: false),
                    FrequenciaMaxMhz = table.Column<int>(type: "int", nullable: false),
                    PontuacaoPassMarkG3D = table.Column<int>(type: "int", nullable: false),
                    TecnologiasSuportadas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersaoPcie = table.Column<int>(type: "int", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gpus_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hds_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    TipoMemoria = table.Column<int>(type: "int", nullable: false),
                    Latencia = table.Column<int>(type: "int", nullable: false),
                    Voltagem = table.Column<double>(type: "float", nullable: false),
                    Ecc = table.Column<bool>(type: "bit", nullable: false),
                    XmpSuportado = table.Column<bool>(type: "bit", nullable: false),
                    Modulos = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rams_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ssds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ssds_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TamanhoRadiador_mm = table.Column<int>(type: "int", nullable: false),
                    QuantidadeFans = table.Column<int>(type: "int", nullable: false),
                    TdpMaximo = table.Column<int>(type: "int", nullable: false),
                    SocketsSuportados = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterCoolers_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
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
                    MinimoNucleosCpu = table.Column<int>(type: "int", nullable: false),
                    MinimoClockCpuMhz = table.Column<int>(type: "int", nullable: false),
                    MinimoClockGpuMhz = table.Column<int>(type: "int", nullable: false),
                    MinimoVRamGpuGb = table.Column<int>(type: "int", nullable: false),
                    MinimoRamGb = table.Column<int>(type: "int", nullable: false),
                    MinimoArmazenamentoGb = table.Column<int>(type: "int", nullable: false),
                    PontuacaoPassMarkG3D = table.Column<int>(type: "int", nullable: false),
                    PontuacaoCpuMark = table.Column<int>(type: "int", nullable: false),
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
                    SocketProcessador = table.Column<int>(type: "int", nullable: false),
                    ChipsetId = table.Column<int>(type: "int", nullable: false),
                    TamanhoPlacaMae = table.Column<int>(type: "int", nullable: false),
                    TipoMemoria = table.Column<int>(type: "int", nullable: false),
                    SlotsMemoria = table.Column<int>(type: "int", nullable: false),
                    MaxMemoriaSuportadaGb = table.Column<int>(type: "int", nullable: false),
                    VersaoPcie = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    ConsumoEmWatts = table.Column<int>(type: "int", nullable: false),
                    Imagens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miniatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacasMae", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacasMae_Chipsets_ChipsetId",
                        column: x => x.ChipsetId,
                        principalTable: "Chipsets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacasMae_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PciExpressSlot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Tamanho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersaoPcie = table.Column<int>(type: "int", nullable: false),
                    SuportaSli = table.Column<bool>(type: "bit", nullable: false),
                    PlacaMaeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PciExpressSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PciExpressSlot_PlacasMae_PlacaMaeId",
                        column: x => x.PlacaMaeId,
                        principalTable: "PlacasMae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chipsets_FabricanteId",
                table: "Chipsets",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_FabricanteId",
                table: "Cpus",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Fontes_FabricanteId",
                table: "Fontes",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Gabinetes_FabricanteId",
                table: "Gabinetes",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Gpus_FabricanteId",
                table: "Gpus",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Hds_FabricanteId",
                table: "Hds",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_PciExpressSlot_PlacaMaeId",
                table: "PciExpressSlot",
                column: "PlacaMaeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_ChipsetId",
                table: "PlacasMae",
                column: "ChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacasMae_FabricanteId",
                table: "PlacasMae",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_FabricanteId",
                table: "Rams",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitosHardware_SoftwareId",
                table: "RequisitosHardware",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Ssds_FabricanteId",
                table: "Ssds",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterCoolers_FabricanteId",
                table: "WaterCoolers",
                column: "FabricanteId");
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
                name: "PciExpressSlot");

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
                name: "PlacasMae");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "Chipsets");

            migrationBuilder.DropTable(
                name: "Fabricante");
        }
    }
}
