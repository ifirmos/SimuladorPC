using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SimuladorPC.Infrastructure.Repositories;

public class PlacaMaeRepository : BaseRepository<PlacaMae>, IPlacaMaeRepository
{
    public PlacaMaeRepository(SimuladorPcContext context) : base(context)
    {
    }

    public IEnumerable<PlacaMae> BuscaPorSocket(int socketId)
    {
        return _entities
            .Include(pm => pm.Chipset) 
            .Include(pm => pm.SocketProcessador) 
            .Where(pm => pm.SocketProcessadorId == socketId)
            .ToList();
    }

    public IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId)
    {
        var placaMae = _entities.OfType<PlacaMae>()
                            .Include(pm => pm.SocketProcessador)
                            .AsNoTracking()
                            .FirstOrDefault(pm => pm.Id == placaMaeId);

        if (placaMae == null)
        {
            return Enumerable.Empty<Cpu>();
        }

        var cpusCompatíveis = _context.Set<Cpu>()
                                .Where(cpu => cpu.SocketProcessadorId == placaMae.SocketProcessadorId);

        return cpusCompatíveis;
    }

    public IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId)
    {
        return _entities
            .Include(pm => pm.Chipset)
            .Include(pm => pm.SocketProcessador)
            .Where(pm => pm.ChipsetId == chipsetId)
            .ToList();
    }
}
