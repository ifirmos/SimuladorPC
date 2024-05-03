namespace SimuladorPC.Domain.Entities.Hardware;

public class Hd : Componente
{
    public int Capacidade { get; private set; }
    public string Velocidade { get; private set; }
}
