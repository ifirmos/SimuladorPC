using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class GpuRepository : BaseRepository<Gpu>, IGpuRepository
{
    public GpuRepository(SimuladorPcContext context) : base(context)
    {
    }
}

