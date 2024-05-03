using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class FonteService : ComponenteService<Fonte>, IFonteService
{
    public FonteService(IBaseRepository<Fonte> repository) : base(repository)
    {
    }
}
