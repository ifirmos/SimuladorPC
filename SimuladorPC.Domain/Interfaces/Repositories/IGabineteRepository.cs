
using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IGabineteRepository
{
    void Add(Gabinete gabinete);    
    IEnumerable<Gabinete> GetAll();    
}
