using SimuladorPC.Data;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;
namespace SimuladorPC.Infrastructure.Repositories;

public class GabineteRepository : BaseRepository<Gabinete>, IGabineteRepository
{
    public GabineteRepository(SimuladorPcContext context) : base(context)
    {
    }

}


