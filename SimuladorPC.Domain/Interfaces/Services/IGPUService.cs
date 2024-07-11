using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface IGpuService : IComponenteService<Gpu>
{
    IEnumerable<Gpu> ObterGpusPorMarca(string marca);
    IEnumerable<Gpu> ObterGpusPorModelo(string modelo);
    IEnumerable<PlacaMae> ListarPlacasMaeCompativeis(int idGpu);
}
