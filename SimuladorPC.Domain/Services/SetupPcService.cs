using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class SetupPcService : ISetupPcService
{
    SetupPc ISetupPcService.InicializarSetup()
    {
        return new SetupPc();
    }
    SetupPc ISetupPcService.AddComponenteAoSetup(SetupPc setup, int componentId, Type componentType)
    {
        throw new NotImplementedException();
    }


    IEnumerable<Cpu> ISetupPcService.ObterCpusCompativeis(int gpuId)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Fonte> ISetupPcService.ObterFontesCompativeis(SetupPc setup)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Gpu> ISetupPcService.ObterGpusCompativeis(int cpuId)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Ram> ISetupPcService.ObterRamsCompativeis(int motherboardId)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Ssd> ISetupPcService.ObterSsdsCompativeis(int motherboardId)
    {
        throw new NotImplementedException();
    }

    bool ISetupPcService.ValidarSetup(SetupPc setup)
    {
        throw new NotImplementedException();
    }
}
