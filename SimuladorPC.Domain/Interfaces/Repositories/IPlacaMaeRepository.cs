using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IPlacaMaeRepository : IBaseRepository<PlacaMae>
{
    IEnumerable<PlacaMae> BuscaPorSocket(int socketId);
    IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId);
}