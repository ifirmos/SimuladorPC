using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class RamRepository : BaseRepository<Ram>, IRamRepository
{
    public RamRepository(SimuladorPcContext context) : base(context)
    {
    }

    public override IEnumerable<Ram> GetAll()
    {
        return _entities.Include(r => r.TipoMemoria).ToList();
    }

    public override Ram ObterPorId(int id)
    {
        return _entities.Include(r => r.TipoMemoria)
                        .SingleOrDefault(r => r.Id == id);
    }
}
