using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface IWaterCoolerService : IComponenteService<WaterCooler>
{
    WaterCooler AdicionarWaterCooler(WaterCooler waterCooler);
}