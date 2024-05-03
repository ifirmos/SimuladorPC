using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class PlacaMaeRepository : BaseRepository<PlacaMae>, IPlacaMaeRepository
{
    public PlacaMaeRepository(SimuladorPcContext context) : base(context)
    {
    }

    public IEnumerable<PlacaMae> BuscaPorSocket(int socketId)
    {
        return _entities.OfType<PlacaMae>().Where(pm => pm.SocketProcessadorId == socketId).ToList();
    }

    public IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId)
    {
        return _entities.OfType<PlacaMae>().Where(pm => pm.ChipsetId == chipsetId).ToList();
    }
}
