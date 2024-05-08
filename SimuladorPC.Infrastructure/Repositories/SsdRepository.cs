using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class SsdRepository : BaseRepository<Ssd>, IFonteRepository
{
    public SsdRepository(SimuladorPcContext context) : base(context)
    {
    }
}
