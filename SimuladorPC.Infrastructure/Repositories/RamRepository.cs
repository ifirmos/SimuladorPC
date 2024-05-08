using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;
namespace SimuladorPC.Infrastructure.Repositories;

public class RamRepository : BaseRepository<Ram>, IRamRepository
{
    public RamRepository(SimuladorPcContext context) : base(context)
    {
    }
}
