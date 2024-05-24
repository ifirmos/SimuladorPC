using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface ICpuService : IComponenteService<Cpu>
{
    public IEnumerable<Cpu> ObterCpusCompativeis(SetupPc setupPc);
}