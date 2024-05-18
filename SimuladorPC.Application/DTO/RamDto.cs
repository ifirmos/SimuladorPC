namespace SimuladorPC.Application.DTO;

public class RamDto : ComponenteDto
{
    public int CapacidadeGb { get; set; }
    public int ClockBaseMhz { get; set; }
    public int ClockMaximoOverclockMhz { get; set; }
    public bool Rgb { get; set; }
    public string TipoMemoria { get; set; } // DDR4, DDR5, etc.
    public int Latencia { get; set; } // Latência CAS da memória, importante para o desempenho.
    public double Voltagem { get; set; } // Voltagem operacional da RAM.
    public bool Ecc { get; set; } // Indica se a memória possui ECC (Error-Correcting Code).
    public bool XmpSuportado { get; set; } // Suporte para Intel XMP para facilitar o overclock.
    public int Modulos { get; set; } // Quantidade de módulos no kit (por exemplo, 2 para um kit dual-channel).
}
