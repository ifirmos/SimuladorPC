using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class GabineteService : ComponenteService<Gabinete>, IGabineteService
{
    public GabineteService(IBaseRepository<Gabinete> repository) : base(repository)
    {
    }
}
