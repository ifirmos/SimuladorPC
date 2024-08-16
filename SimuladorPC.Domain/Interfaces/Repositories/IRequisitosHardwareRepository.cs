using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;

public interface IRequisitosHardwareRepository : IBaseRepository<RequisitosHardware>
{
    Cpu ObterCpuCompativel(RequisitosHardware requisitos);
    Gpu ObterGpuCompativel(RequisitosHardware requisitos, SetupPc setupPc);
    PlacaMae ObterPlacaMaeCompativel(RequisitosHardware requisitos, SetupPc setupPc);
    Ram ObterRamCompativel(RequisitosHardware requisitos, SetupPc setupPc);
    Ssd ObterSsdCompativel(RequisitosHardware requisitos, SetupPc setupPc);
    Gabinete ObterGabineteAdequado(RequisitosHardware requisitos, SetupPc setupPc);
    WaterCooler ObterWaterCoolerCompativel(RequisitosHardware requisitos, SetupPc setupPc);
    Fonte ObterFonteAdequada(SetupPc setupPc);
}
