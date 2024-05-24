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

    //public override IEnumerable<PlacaMae> GetAll()
    //{
    //    return _entities
    //        .Include(p => p.Chipset)
    //        .Include(p => p.TamanhoPlacaMae)
    //        .Include(p => p.SocketProcessador)
    //        .Include(p => p.TipoMemoria);
    //}

    public override PlacaMae GetById(int id)
    {
        return _entities.Include(p => p.Chipset)
                        .Include(p => p.TamanhoPlacaMae)
                        .Include(p => p.SocketProcessador)
                        .Include(p => p.TipoMemoria)
                        .Include(p => p.PciExpressSlots)
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
    public bool VerificarCpuCompativel(PlacaMae placaMae, Cpu cpu)
    {
        return placaMae.SocketProcessadorId == cpu.SocketProcessadorId;
    }

    public bool VerificarGpuCompativel(PlacaMae placaMae, Gpu gpu)
    {
        return placaMae.PciExpressSlots.Any(slot => slot.VersaoPcie >= gpu.VersaoPcie);
    }

    public bool VerificarGabineteCompativel(PlacaMae placaMae, Gabinete gabinete)
    {
        // Adicione lógica específica para verificar compatibilidade com o gabinete, se aplicável
        return true;
    }

    public bool VerificarSsdCompativel(PlacaMae placaMae, Ssd ssd)
    {
        // Adicione lógica específica para verificar compatibilidade com SSD, se aplicável
        return true;
    }    
}
