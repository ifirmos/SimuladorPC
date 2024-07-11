using System.Collections.Generic;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class GpuService : ComponenteService<Gpu>, IGpuService
{
    private readonly IGpuRepository _gpuRepository;

    public GpuService(IGpuRepository gpuRepository) : base(gpuRepository)
    {
        _gpuRepository = gpuRepository;
    }
    public IEnumerable<Gpu> ObterGpusPorMarca(string marca)
    {
        return _gpuRepository.ObterGpusPorMarca(marca);
    }
    public IEnumerable<Gpu> ObterGpusPorModelo(string modelo)
    {
        return _gpuRepository.ObterGpusPorModelo(modelo);
    }
    public IEnumerable<PlacaMae> ListarPlacasMaeCompativeis(int idGpu)
    {
        return _gpuRepository.ListarPlacasMaeCompativeis(idGpu);
    }
}
