using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class RamService : ComponenteService<Ram>, IRamService
{
    public RamService(IBaseRepository<Ram> repository) : base(repository)
    {
    }
}
