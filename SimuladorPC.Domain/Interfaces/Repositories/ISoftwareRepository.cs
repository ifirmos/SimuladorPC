using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface ISoftwareRepository : IBaseRepository<Software>
{
    Cpu ObterCpuCompativel(Software software);
    Fonte ObterFonteAdequada(SetupPc setupPc);
    Gabinete ObterGabineteAdequado(SetupPc setupPc);
    Gpu ObterGpuCompativel(Software software, SetupPc setupPc);
    PlacaMae ObterPlacaMaeCompativel(SetupPc setupPc);
    Ram ObterRamCompativel(Software software, SetupPc setupPc);
    Software ObterSoftwarePorNome(string softwareNome);
    Ssd ObterSsdCompativel(Software software, SetupPc setupPc);
    WaterCooler ObterWaterCoolerCompativel(SetupPc setupPc);
}
