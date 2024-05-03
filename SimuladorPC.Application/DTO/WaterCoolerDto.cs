using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Application.DTO;

public class WaterCooler : Componente
{
    public string TamanhoRadiador { get; private set; }
    public int QuantidadeFans { get; private set; }
}
