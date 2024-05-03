namespace SimuladorPC.Domain.Entities.Hardware;

public class Ram : Componente
{
    public int CapacidadeGb { get; private set; }
    public int Clock { get; private set; }
    public bool Rgb { get; private set; }
}
