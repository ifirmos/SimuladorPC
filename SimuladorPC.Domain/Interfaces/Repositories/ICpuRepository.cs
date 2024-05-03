using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface ICpuRepository : IBaseRepository<Cpu>
{
    IEnumerable<Cpu> ObterCPUsCompativeisPorSocket(string tipoSocket);
}
