using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class PlacaMaeService : ComponenteService<PlacaMae>, IPlacaMaeService
{
    private readonly IPlacaMaeRepository _placaMaeRepository;
    private readonly IBaseRepository<Chipset> _chipsetRepository;

    public PlacaMaeService(
        IPlacaMaeRepository placaMaeRepository, 
        IBaseRepository<Chipset> chipsetRepository)
        : base(placaMaeRepository) 
    {
        _placaMaeRepository = placaMaeRepository;
        _chipsetRepository = chipsetRepository;
    }

    
    public IEnumerable<PlacaMae> BuscarPorChipset(int chipsetId)
    {
        return _placaMaeRepository.BuscaPorChipset(chipsetId);
    }

    public PlacaMae AdicionarPlacaMae(PlacaMae placaMae)
    {
        if (_placaMaeRepository.Any(p => p.Nome.Trim().ToLower() == placaMae.Nome.Trim().ToLower()))
        {
            throw new Exception("Uma placa mãe com o mesmo nome já existe.");
        }

        var chipsetExiste = _chipsetRepository.ObterPorId(placaMae.ChipsetId);
        if (chipsetExiste != null)
        {
            placaMae.SetChipset(chipsetExiste.Id);
        }

        var existingTamanhoPlacaMae = _chipsetRepository.ObterPorId(placaMae.TamanhoPlacaMaeId);
        if (existingTamanhoPlacaMae != null)
        {
            placaMae.SetTamanhoPlacaMae(existingTamanhoPlacaMae.Id);
        }

        var existingTipoMemoria = _chipsetRepository.ObterPorId(placaMae.TipoMemoriaId);
        if (existingTipoMemoria != null)
        {
            placaMae.SetTipoMemoria(existingTipoMemoria.Id);
        }

        _placaMaeRepository.Add(placaMae);
        return placaMae;
    }

    public bool VerificarCpuCompativel(PlacaMae placaMae, Cpu cpu)
    {
        return placaMae.SocketProcessador == cpu.SocketProcessador;
    }
    public bool VerificarGpuCompativel(PlacaMae placaMae, Gpu gpu)
    {
        return placaMae.PciExpressSlots.Any(slot => slot.VersaoPcie >= gpu.VersaoPcie);
    }
    public bool VerificarGabineteCompativel(PlacaMae placaMae, Gabinete gabinete)
    {
        // Refatorar -> lógica específica para verificar compatibilidade com o gabinete
        return true; // true por enquanto
    }
    public bool VerificarSsdCompativel(PlacaMae placaMae, Ssd ssd)
    {
        // Refatorar -> lógica específica para verificar compatibilidade
        return true; 
    }
}
