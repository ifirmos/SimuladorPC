using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class SsdService : ComponenteService<Ssd>, ISsdService
{
    public SsdService(IBaseRepository<Ssd> repository) : base(repository)
    {
    }
}
