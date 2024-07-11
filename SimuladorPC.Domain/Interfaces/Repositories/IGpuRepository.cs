using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IGpuRepository : IBaseRepository<Gpu>
{
    IEnumerable<Gpu> ObterGpusPorMarca(string marca);
    IEnumerable<Gpu> ObterGpusPorModelo(string modelo);
    IEnumerable<PlacaMae> ListarPlacasMaeCompativeis(int idGpu);
}
