using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface ISetupPcService
{
    SetupPc InicializarSetup();
    IEnumerable<Cpu> ObterCpusCompativeis(int gpuId);
    IEnumerable<Gpu> ObterGpusCompativeis(int cpuId);
    IEnumerable<Ram> ObterRamsCompativeis(int motherboardId);
    IEnumerable<Ssd> ObterSsdsCompativeis(int motherboardId);
    IEnumerable<Fonte> ObterFontesCompativeis(SetupPc setup);
    SetupPc AddComponenteAoSetup(SetupPc setup, int componentId, Type componentType);
    bool ValidarSetup(SetupPc setup);
}

