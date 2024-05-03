namespace SimuladorPC.Domain.Entities.Hardware;

public class WaterCooler : Componente
{
    public string TamanhoRadiador { get; private set; }
    public int QuantidadeFans { get; private set; }
}
