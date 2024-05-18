using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class PlacaMaeService : ComponenteService<PlacaMae>, IPlacaMaeService
{
    private readonly IPlacaMaeRepository _placaMaeRepository;
    private readonly IBaseRepository<Chipset> _chipsetRepository;

    public PlacaMaeService(IPlacaMaeRepository placaMaeRepository, IBaseRepository<Chipset> chipsetRepository)
        : base(placaMaeRepository) 
    {
        _placaMaeRepository = placaMaeRepository;
        _chipsetRepository = chipsetRepository;
    }

    public IEnumerable<PlacaMae> BuscarPorSocket(int socketId)
    {
        return _placaMaeRepository.BuscaPorSocket(socketId);
    }
    public IEnumerable<PlacaMae> BuscarPorChipset(int chipsetId)
    {
        return _placaMaeRepository.BuscaPorChipset(chipsetId);
    }

    public PlacaMae AdicionarPlacaMae(PlacaMae placaMae)
    {
        if (_placaMaeRepository.Any(p => p.Nome.Trim().ToLower() == placaMae.Nome.Trim().ToLower()))
        {
            throw new Exception("Um placaMae com o mesmo nome já existe.");
        }

        _placaMaeRepository.Add(placaMae);
        return placaMae;
    }

    public IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId)
    {
        throw new NotImplementedException();
    }
}
