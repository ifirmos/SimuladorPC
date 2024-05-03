using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class PlacaMaeService(IBaseRepository<PlacaMae> repository, IPlacaMaeRepository placaMaeRepository) : ComponenteService<PlacaMae>(repository), IPlacaMaeService
{
    private readonly IPlacaMaeRepository _placaMaeRepository = placaMaeRepository;

    public IEnumerable<PlacaMae> BuscarPorSocket(int socketId)
    {
        return _placaMaeRepository.BuscaPorSocket(socketId);
    }
    public IEnumerable<PlacaMae> BuscarPorChipset(int chipsetId)
    {
        return _placaMaeRepository.BuscaPorChipset(chipsetId);
    }
}
