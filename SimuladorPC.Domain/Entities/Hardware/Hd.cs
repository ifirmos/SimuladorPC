namespace SimuladorPC.Domain.Entities.Hardware;

public class Hd : Componente
{
    public int CapacidadeGb { get; private set; }
    public string Velocidade { get; private set; }
}
