
namespace SimuladorPC.Domain.Entities.Hardware;

public class Ram : Componente
{
    public int CapacidadeGb { get; private set; }
    public int ClockBaseMhz { get; private set; }
    public int ClockMaximoOverclockMhz { get; private set; }
    public bool Rgb { get; private set; }
    public virtual TipoMemoria TipoMemoria { get; private set; } // DDR4, DDR5, etc.
    public int Latencia { get; private set; } // Latência CAS da memória, importante para o desempenho.
    public double Voltagem { get; private set; } // Voltagem operacional da RAM.
    public bool Ecc { get; private set; } // Indica se a memória possui ECC (Error-Correcting Code).
    public bool XmpSuportado { get; private set; } // Suporte para Intel XMP para facilitar o overclock.
    public int Modulos { get; private set; } // Quantidade de módulos no kit (por exemplo, 2 para um kit dual-channel).

    internal void SetTipoRam(TipoMemoria existingTipoRam)
    {
        TipoMemoria = existingTipoRam;
    }
}

