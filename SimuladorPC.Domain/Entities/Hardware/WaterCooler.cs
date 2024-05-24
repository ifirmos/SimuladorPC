namespace SimuladorPC.Domain.Entities.Hardware;

public class WaterCooler : Componente
{
    public int TamanhoRadiador_mm { get; private set; }
    public int QuantidadeFans { get; private set; }
}
