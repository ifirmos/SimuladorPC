namespace SimuladorPC.Domain.Entities.Hardware;

public class PortaUSB
{
    public string? TipoUSB { get; private set; }
    public int Quantidade { get; private set; }
    public bool Externa { get; private set; }
}
