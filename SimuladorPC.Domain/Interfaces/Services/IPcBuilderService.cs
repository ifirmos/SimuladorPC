using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface IPcBuilderService
{
    SetupPc AutoBuildPcConfiguration(Software software);
}
