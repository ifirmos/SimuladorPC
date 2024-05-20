using System.Net.Sockets;

namespace SimuladorPC.Domain.Entities.Hardware;

public class Cpu : Componente
{
    public string LinhaProduto { get; private set; }
    public int TecnologiaFabricacao { get; private set; } // Nanômetros
    public int CacheL1 { get; private set; }
    public int CacheL2 { get; private set; }
    public int CacheL3 { get; private set; }
    public bool SuporteMultithreading { get; private set; }
    public string ConjuntoInstrucoes { get; private set; }
    public int FrequenciaBoostMhz { get; private set; }
    public int ConsumoEnergia { get; private set; }
    public bool GraficosIntegrados { get; private set; }
    public int TemperaturaMaxima { get; private set; }
    public string SuporteMemoria { get; private set; }
    public int NumeroCanaisMemoria { get; private set; }
    public string Plataforma { get; private set; }
    public string PcieVersao { get; private set; }
    public int PcieLanes { get; private set; }
    public int Nucleos { get; private set; }
    public int Threads { get; private set; }
    public int FrequenciaBaseMhz { get; private set; }
    public int FrequenciaMaximaMhz { get; private set; }
    public virtual SocketProcessador Socket { get; private set; }
    public int SocketProcessadorId { get; private set; }
    public int Tdp { get; private set; }

    public void SetSocket(SocketProcessador socket)
    {
        Socket = socket;
        SocketProcessadorId = socket.Id;
    }
}

