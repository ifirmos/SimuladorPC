using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Application.DTO;

public class CpuDto : ComponenteDto
{
    public string LinhaProduto { get;set; }
    public int TecnologiaFabricacao { get;set; } // Nan�metros
    public int CacheL1 { get;set; }
    public int CacheL2 { get;set; }
    public int CacheL3 { get;set; }
    public bool SuporteMultithreading { get;set; }
    public string ConjuntoInstrucoes { get;set; }
    public int FrequenciaBoost { get;set; }
    public int ConsumoEnergia { get;set; }
    public bool GraficosIntegrados { get;set; }
    public int TemperaturaMaxima { get;set; }
    public string SuporteMemoria { get;set; }
    public int NumeroCanaisMemoria { get;set; }
    public string Plataforma { get;set; }
    public string PcieVersao { get;set; }
    public int PcieLanes { get;set; }
    public int Nucleos { get;set; }
    public int Threads { get;set; }
    public float FrequenciaBase { get;set; }
    public float FrequenciaMaxima { get;set; }
    public string Socket { get;set; }
    public int Tdp { get;set; }
}