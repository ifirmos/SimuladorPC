using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class CpuRepository : BaseRepository<Cpu>, ICpuRepository
{
    public CpuRepository(SimuladorPcContext context) : base(context)
    {
    }

    public override IEnumerable<Cpu> GetAll()
    {
        return _entities;
    }
}

