using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface ISoftwareRepository : IBaseRepository<Software>
{
    Cpu ObterCpuCompativel(Software software);
    Gpu ObterGpuCompativel(Software software, SetupPc setupPc);
    PlacaMae ObterPlacaMaeCompativel(SetupPc setupPc);
    Ram ObterRamCompativel(Software software, SetupPc setupPc);
    Ssd ObterSsdCompativel(Software software, SetupPc setupPc);
    Gabinete ObterGabineteAdequado(SetupPc setupPc);
    WaterCooler ObterWaterCoolerCompativel(SetupPc setupPc);
    Fonte ObterFonteAdequada(SetupPc setupPc);
    Software ObterSoftwarePorNome(string softwareNome);
}
