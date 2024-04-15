namespace SimuladorPC.Domain;

public class PortaUsb
{
    public string Versao { get; set; } // Ex: "2.0", "3.0", "3.1", "3.2", "Type-C"
    public int Quantidade { get; set; } // Número de portas desse tipo
}
