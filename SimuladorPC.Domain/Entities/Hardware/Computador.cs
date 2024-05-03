namespace SimuladorPC.Domain.Entities.Hardware;

public class Computador : SetupPc
{
    public int ComputadorId { get; private set; }
    public string Sku { get; private set; }
    public string Descricao { get; private set; }
}

