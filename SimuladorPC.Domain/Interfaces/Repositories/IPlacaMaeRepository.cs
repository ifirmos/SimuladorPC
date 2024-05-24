using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IPlacaMaeRepository : IBaseRepository<PlacaMae>
{
    IEnumerable<PlacaMae> BuscaPorSocket(int socketId);
    IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId);
    IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId);
    bool VerificarCpuCompativel(PlacaMae placaMae, Cpu cpu);
    bool VerificarGpuCompativel(PlacaMae placaMae, Gpu gpu);
    bool VerificarGabineteCompativel(PlacaMae placaMae, Gabinete gabinete);
    bool VerificarSsdCompativel(PlacaMae placaMae, Ssd ssd);
}