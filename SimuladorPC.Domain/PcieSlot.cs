namespace SimuladorPC.Domain;

public class PcieSlot
{
    public string Versao { get; set; } // Ex: "3.0", "4.0", "5.0"
    public string Formato { get; set; } // Ex: "x16", "x8", "x4", "x1"
}