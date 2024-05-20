using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class PlacaMaeRepository : BaseRepository<PlacaMae>, IPlacaMaeRepository
{
    public PlacaMaeRepository(SimuladorPcContext context) : base(context)
    {
    }

    public override IEnumerable<PlacaMae> GetAll()
    {
        return _entities
            .Include(p => p.Chipset)
            .Include(p => p.TamanhoPlacaMae)
            .Include(p => p.SocketProcessador)
            .Include(p => p.TipoMemoria);
    }

    public override PlacaMae GetById(int id)
    {
        return _entities.Include(p => p.Chipset)
                        .Include(p => p.TamanhoPlacaMae)
                        .Include(p => p.SocketProcessador)
                        .Include(p => p.TipoMemoria)
                        .SingleOrDefault(p => p.Id == id);
    }
    public IEnumerable<PlacaMae> BuscaPorSocket(int socketId)
    {
        return _entities
            .Include(pm => pm.Chipset)
            .Include(pm => pm.SocketProcessador)
            .Include(pm => pm.TamanhoPlacaMae)
            .Include(pm => pm.TipoMemoria)
            .Where(pm => pm.SocketProcessadorId == socketId)
            .ToList();
    }

    public IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId)
    {
        var placaMae = _entities
            .Include(pm => pm.SocketProcessador)
            .AsNoTracking()
            .FirstOrDefault(pm => pm.Id == placaMaeId);

        if (placaMae == null)
        {
            return Enumerable.Empty<Cpu>();
        }

        return _context.Set<Cpu>()
            .Where(cpu => cpu.SocketProcessadorId == placaMae.SocketProcessadorId)
            .ToList();
    }

    public IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId)
    {
        return _entities
            .Include(pm => pm.Chipset)
            .Include(pm => pm.SocketProcessador)
            .Include(pm => pm.TamanhoPlacaMae)
            .Include(pm => pm.TipoMemoria)
            .Where(pm => pm.ChipsetId == chipsetId)
            .ToList();
    }
}
