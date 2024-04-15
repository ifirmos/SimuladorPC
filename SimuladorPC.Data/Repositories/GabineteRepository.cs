using SimuladorPC.Domain.Entities;
using SimuladorPC.Domain.Interfaces.Repositories;
namespace SimuladorPC.Data.Repositories;

public class GabineteRepository(SimuladorPcContext context) : IGabineteRepository
{
    private readonly SimuladorPcContext _context = context;

    public void Add(Gabinete gabinete)
    {
        _context.Gabinetes.Add(gabinete);
        _context.SaveChanges();
    }

    public IEnumerable<Gabinete> GetAll()
    {
        return _context.Gabinetes.ToList();
    }
}
