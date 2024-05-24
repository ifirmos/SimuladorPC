﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimuladorPC.Infrastructure.Data;

#nullable disable

namespace SimuladorPC.Infrastructure.Migrations
{
    [DbContext(typeof(SimuladorPcContext))]
    partial class SimuladorPcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Chipset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Modelo")
                        .IsUnique();

                    b.ToTable("Chipsets");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Cpu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CacheL1")
                        .HasColumnType("int");

                    b.Property<int>("CacheL2")
                        .HasColumnType("int");

                    b.Property<int>("CacheL3")
                        .HasColumnType("int");

                    b.Property<string>("ConjuntoInstrucoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumoEnergia")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrequenciaBaseMhz")
                        .HasColumnType("int");

                    b.Property<int>("FrequenciaBoostMhz")
                        .HasColumnType("int");

                    b.Property<int>("FrequenciaMaximaMhz")
                        .HasColumnType("int");

                    b.Property<bool>("GraficosIntegrados")
                        .HasColumnType("bit");

                    b.Property<string>("LinhaProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nucleos")
                        .HasColumnType("int");

                    b.Property<int>("NumeroCanaisMemoria")
                        .HasColumnType("int");

                    b.Property<int>("PcieLanes")
                        .HasColumnType("int");

                    b.Property<string>("PcieVersao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plataforma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoCpuMark")
                        .HasColumnType("int");

                    b.Property<int>("SocketProcessadorId")
                        .HasColumnType("int");

                    b.Property<string>("SuporteMemoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SuporteMultithreading")
                        .HasColumnType("bit");

                    b.Property<int>("Tdp")
                        .HasColumnType("int");

                    b.Property<int>("TecnologiaFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("TemperaturaMaxima")
                        .HasColumnType("int");

                    b.Property<int>("Threads")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocketProcessadorId");

                    b.ToTable("Cpus");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Fonte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Modular")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PFCAtivo")
                        .HasColumnType("bit");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fontes");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Gabinete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura_Cm")
                        .HasColumnType("int");

                    b.Property<int>("BaiasExternas")
                        .HasColumnType("int");

                    b.Property<int>("BaiasInternas")
                        .HasColumnType("int");

                    b.Property<int>("Comprimento_Cm")
                        .HasColumnType("int");

                    b.Property<string>("CorGabinete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorIluminacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Largura_Cm")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso_Kg")
                        .HasColumnType("real");

                    b.Property<int>("SuporteRadiador_mm")
                        .HasColumnType("int");

                    b.Property<bool>("TemJanela")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Gabinetes");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Gpu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Comprimento")
                        .HasColumnType("float");

                    b.Property<int>("Comprimento_Cm")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrequenciaBaseMhz")
                        .HasColumnType("int");

                    b.Property<int>("FrequenciaMaxMhz")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso_Kg")
                        .HasColumnType("real");

                    b.Property<int>("PontuacaoPassMarkG3D")
                        .HasColumnType("int");

                    b.Property<int>("PortasDisplayPort")
                        .HasColumnType("int");

                    b.Property<int>("PortasHdmi")
                        .HasColumnType("int");

                    b.Property<int>("PotenciaRecomendadaEmWatts")
                        .HasColumnType("int");

                    b.Property<int>("QtdCoolers")
                        .HasColumnType("int");

                    b.Property<int>("QtdMemoriaEmGb")
                        .HasColumnType("int");

                    b.Property<string>("TecnologiasSuportadas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VersaoPcie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gpus");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Hd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadeGb")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Velocidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hds");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Iluminacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorFixa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoIluminacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposIluminacao");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.PciExpressSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PlacaMaeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<bool>("SuportaSli")
                        .HasColumnType("bit");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VersaoPcie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlacaMaeId");

                    b.ToTable("PciExpressSlot");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.PlacaMae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChipsetId")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxMemoriaSuportadaGb")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SlotsMemoria")
                        .HasColumnType("int");

                    b.Property<int>("SocketProcessadorId")
                        .HasColumnType("int");

                    b.Property<int>("TamanhoPlacaMaeId")
                        .HasColumnType("int");

                    b.Property<int>("TipoMemoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChipsetId");

                    b.HasIndex("SocketProcessadorId");

                    b.HasIndex("TamanhoPlacaMaeId");

                    b.HasIndex("TipoMemoriaId");

                    b.ToTable("PlacasMae");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Ram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadeGb")
                        .HasColumnType("int");

                    b.Property<int>("ClockBaseMhz")
                        .HasColumnType("int");

                    b.Property<int>("ClockMaximoOverclockMhz")
                        .HasColumnType("int");

                    b.Property<bool>("Ecc")
                        .HasColumnType("bit");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Latencia")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Modulos")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rgb")
                        .HasColumnType("bit");

                    b.Property<int>("TipoMemoriaId")
                        .HasColumnType("int");

                    b.Property<double>("Voltagem")
                        .HasColumnType("float");

                    b.Property<bool>("XmpSuportado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("TipoMemoriaId");

                    b.ToTable("Rams");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.SocketProcessador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocketProcessadores");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Ssd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadeGb")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Formato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VelocidadeEscritaEmMbps")
                        .HasColumnType("int");

                    b.Property<int>("VelocidadeLeituraEmMbps")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ssds");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.TamanhoPlacaMae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TamanhoPlacaMae");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.TipoMemoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposMemoria");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.WaterCooler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeFans")
                        .HasColumnType("int");

                    b.Property<int>("TamanhoRadiador_mm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WaterCoolers");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Software.RequisitosHardware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MinimoArmazenamentoGb")
                        .HasColumnType("int");

                    b.Property<int>("MinimoClockCpuMhz")
                        .HasColumnType("int");

                    b.Property<int>("MinimoClockGpuMhz")
                        .HasColumnType("int");

                    b.Property<int>("MinimoNucleosCpu")
                        .HasColumnType("int");

                    b.Property<int>("MinimoRamGb")
                        .HasColumnType("int");

                    b.Property<int>("MinimoVRamGpuGb")
                        .HasColumnType("int");

                    b.Property<int>("NivelDesempenho")
                        .HasColumnType("int");

                    b.Property<int>("PontuacaoCpuMark")
                        .HasColumnType("int");

                    b.Property<int>("PontuacaoPassMarkG3D")
                        .HasColumnType("int");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("int");

                    b.Property<string>("TecnologiasRequeridas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoArmazenamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SoftwareId");

                    b.ToTable("RequisitosHardware");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Software.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Versao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Cpu", b =>
                {
                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.SocketProcessador", "Socket")
                        .WithMany()
                        .HasForeignKey("SocketProcessadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Socket");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.PciExpressSlot", b =>
                {
                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.PlacaMae", null)
                        .WithMany("PciExpressSlots")
                        .HasForeignKey("PlacaMaeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.PlacaMae", b =>
                {
                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.Chipset", "Chipset")
                        .WithMany()
                        .HasForeignKey("ChipsetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.SocketProcessador", "SocketProcessador")
                        .WithMany()
                        .HasForeignKey("SocketProcessadorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.TamanhoPlacaMae", "TamanhoPlacaMae")
                        .WithMany()
                        .HasForeignKey("TamanhoPlacaMaeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.TipoMemoria", "TipoMemoria")
                        .WithMany()
                        .HasForeignKey("TipoMemoriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Chipset");

                    b.Navigation("SocketProcessador");

                    b.Navigation("TamanhoPlacaMae");

                    b.Navigation("TipoMemoria");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.Ram", b =>
                {
                    b.HasOne("SimuladorPC.Domain.Entities.Hardware.TipoMemoria", "TipoMemoria")
                        .WithMany()
                        .HasForeignKey("TipoMemoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMemoria");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Software.RequisitosHardware", b =>
                {
                    b.HasOne("SimuladorPC.Domain.Entities.Software.Software", null)
                        .WithMany("Requisitos")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Hardware.PlacaMae", b =>
                {
                    b.Navigation("PciExpressSlots");
                });

            modelBuilder.Entity("SimuladorPC.Domain.Entities.Software.Software", b =>
                {
                    b.Navigation("Requisitos");
                });
#pragma warning restore 612, 618
        }
    }
}
