using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface ISoftwareRepository : IBaseRepository<Software>
{
    Cpu ObterCpuCompativel(Software software);
    Fonte ObterFonteAdequada(Software software, SetupPc setupPc);
    Gabinete ObterGabineteAdequado(Software software, SetupPc setupPc);
    Gpu ObterGpuCompativel(Software software, SetupPc setupPc);
    PlacaMae ObterPlacaMaeCompativel(Software software, SetupPc setupPc);
    IEnumerable<Ram> ObterRamsCompativeis(Software software, SetupPc setupPc);
    Software ObterSoftwarePorNome(string softwareNome);
    IEnumerable<Ssd> ObterSsdsCompativeis(Software software, SetupPc setupPc);
    WaterCooler? ObterWaterCoolerCompativel(Software software, SetupPc setupPc);
}
