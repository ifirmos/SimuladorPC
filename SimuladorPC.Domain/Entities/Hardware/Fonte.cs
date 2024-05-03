namespace SimuladorPC.Domain.Entities.Hardware;

public class Fonte : Componente
{
    public int Potencia { get; private set; }
    public bool Modular { get; private set; }
    public bool PFCAtivo { get; private set; }
}
