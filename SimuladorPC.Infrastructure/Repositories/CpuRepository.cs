using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;

namespace SimuladorPC.Infrastructure.Data;

public class CpuRepository(SimuladorPcContext context) : BaseRepository<Cpu>(context), ICpuRepository
{
    public IEnumerable<Cpu> ObterCPUsCompativeisPorSocket(string socketType)
    {
        return context.Cpus.Where(cpu => cpu.Socket.Nome == socketType);
    }
}
