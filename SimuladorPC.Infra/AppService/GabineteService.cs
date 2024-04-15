using SimuladorPC.Domain.Entities;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Application.Services;

public class GabineteService : IGabineteService
{
    private readonly IGabineteRepository _gabineteRepository;

    public GabineteService(IGabineteRepository gabineteRepository)
    {
        _gabineteRepository = gabineteRepository;
    }

    public void AdicionarGabinete(Gabinete gabinete)
    {
        // Adicionar validações e lógica de negócios antes de adicionar o gabinete
        _gabineteRepository.Add(gabinete);
    }

    public IEnumerable<Gabinete> GetAllGabinetes()
    {
        return _gabineteRepository.GetAll();
    }
}
