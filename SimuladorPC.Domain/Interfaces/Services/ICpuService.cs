using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface ICpuService : IComponenteService<Cpu>
{
    //public IEnumerable<WaterCooler> ListarWaterCoolersCompativeis(SetupPc setupPc);
    IEnumerable<WaterCooler> ListarWaterCoolersCompativeis(int cpuId);

}   