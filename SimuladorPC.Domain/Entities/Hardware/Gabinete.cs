namespace SimuladorPC.Domain.Entities.Hardware;

public class Gabinete : Componente
{
    public double Altura { get; private set; }
    public double Largura { get; private set; }
    public double Comprimento { get; private set; }
    public float PesoEmKg { get; private set; }
    public int BaiasInternas { get; private set; }
    public int BaiasExternas { get; private set; }
    public string CorIluminacao { get; private set; }
    public bool TemJanela { get; private set; }
    public string CorGabinete { get; private set; }
}
