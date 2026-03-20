using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class FonteRepository : BaseRepository<Fonte>, IFonteRepository
{
    public FonteRepository(SimuladorPcContext context) : base(context)
    {
    }
}
