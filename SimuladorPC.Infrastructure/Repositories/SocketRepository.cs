using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class SocketProcessadorRepository : BaseRepository<SocketProcessador>, ISocketProcessadorRepository
{
    public SocketProcessadorRepository(SimuladorPcContext context) : base(context)
    {
    }
}
