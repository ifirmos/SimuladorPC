using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Infrastructure.Data;
using System.Net.Sockets;

namespace SimuladorPC.Infrastructure.Repositories;

public class PlacaMaeRepository : BaseRepository<PlacaMae>, IPlacaMaeRepository
{
    public PlacaMaeRepository(SimuladorPcContext context) : base(context)
    {
    }

    public IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId)
    {
        var placaMae = _entities            
            .FirstOrDefault(pm => pm.Id == placaMaeId);

        if (placaMae == null)
        {
            return Enumerable.Empty<Cpu>();
        }

        return _context.Set<Cpu>()
            .Where(cpu => cpu.SocketProcessador == placaMae.SocketProcessador)
            .ToList();
    }

    public IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId)
    {
        return _entities          
            .Where(pm => pm.ChipsetId == chipsetId)
            .ToList();
    }
}
