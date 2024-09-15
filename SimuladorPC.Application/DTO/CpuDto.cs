using SimuladorPC.Domain.Entities;
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class CpuDto : ComponenteDto
{
    public string LinhaProduto { get;set; }
    public int TecnologiaFabricacao { get;set; } // Nanômetros
    public int CacheL1 { get;set; }
    public int CacheL2 { get;set; }
    public int CacheL3 { get;set; }
    public bool SuporteMultithreading { get;set; }
    public string ConjuntoInstrucoes { get;set; }
    public int FrequenciaBoostMhz { get;set; }
    public int ConsumoEnergia { get;set; }
    public bool GraficosIntegrados { get;set; }
    public int TemperaturaMaxima { get;set; }
    public int NumeroCanaisMemoria { get;set; }
    public string Plataforma { get;set; }
    public TipoMemoria TipoMemoria { get;set; }
    public VersaoPcie VersaoPcie { get;  set; }
    public int PcieLanes { get;set; }
    public int Nucleos { get;set; }
    public int Threads { get;set; }
    public int FrequenciaBaseMhz { get;set; }
    public int FrequenciaMaximaMhz { get;set; }
    public int PontuacaoCpuMark { get; set; }
    public SocketProcessador SocketProcessador { get;set; }
    public int Tdp { get;set; }
}
