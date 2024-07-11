using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class GpuRepository(SimuladorPcContext context) : BaseRepository<Gpu>(context), IGpuRepository
{
    IEnumerable<Gpu> IGpuRepository.ObterGpusPorMarca(string marca)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Gpu> IGpuRepository.ObterGpusPorModelo(string modelo)
    {
        throw new NotImplementedException();
    }

    IEnumerable<PlacaMae> IGpuRepository.ListarPlacasMaeCompativeis(int idGpu)
    {
        var gpu = _entities.FirstOrDefault(gpu => gpu.Id == idGpu);

        if (gpu == null)
        {
            return [];
        }

        var placasMaeCompativeis = context.PlacasMae
            .Where(placaMae => placaMae.VersaoPcie >= gpu.VersaoPcie)
            .ToList(); ;

        return placasMaeCompativeis;
    }
}

