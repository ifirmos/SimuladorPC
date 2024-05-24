using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class PlacaMaeService : ComponenteService<PlacaMae>, IPlacaMaeService
{
    private readonly IPlacaMaeRepository _placaMaeRepository;
    private readonly IBaseRepository<Chipset> _chipsetRepository;
    private readonly IBaseRepository<SocketProcessador> _socketRepository;
    private readonly IBaseRepository<TipoMemoria> _tipoMemoriaRepository;
    private readonly IBaseRepository<TamanhoPlacaMae> _tamanhoPlacaMaeRepository;

    public PlacaMaeService(
        IPlacaMaeRepository placaMaeRepository, 
        IBaseRepository<Chipset> chipsetRepository, 
        IBaseRepository<SocketProcessador> socketRepository,
        IBaseRepository<TipoMemoria> tipoMemoriaRepository,
        IBaseRepository<TamanhoPlacaMae> tamanhoPlacaMaeRepository)
        : base(placaMaeRepository) 
    {
        _placaMaeRepository = placaMaeRepository;
        _chipsetRepository = chipsetRepository;
        _socketRepository = socketRepository;
        _tamanhoPlacaMaeRepository = tamanhoPlacaMaeRepository;
        _tipoMemoriaRepository = tipoMemoriaRepository;
    }

    public IEnumerable<PlacaMae> BuscarPorSocket(int socketId)
    {
        return _placaMaeRepository.BuscaPorSocket(socketId);
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

        var existingChipset = _chipsetRepository.Find(c => c.Modelo == placaMae.Chipset.Modelo);
        if (existingChipset != null)
        {
            placaMae.SetChipset(existingChipset);
        }

        var existingSocket = _socketRepository.Find(s => s.Nome == placaMae.SocketProcessador.Nome);
        if (existingSocket != null)
        {
            placaMae.SetSocket(existingSocket);
        }

        var existingTamanhoPlacaMae = _tamanhoPlacaMaeRepository.Find(t => t.Tamanho == placaMae.TamanhoPlacaMae.Tamanho);
        if (existingTamanhoPlacaMae != null)
        {
            placaMae.SetTamanhoPlacaMae(existingTamanhoPlacaMae);
        }

        var existingTipoMemoria = _tipoMemoriaRepository.Find(tm => tm.Tipo == placaMae.TipoMemoria.Tipo);
        if (existingTipoMemoria != null)
        {
            placaMae.SetTipoMemoria(existingTipoMemoria);
        }

        _placaMaeRepository.Add(placaMae);
        return placaMae;
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
        // Refatorar -> lógica específica para verificar compatibilidade com o gabinete
        return true; // true por enquanto
    }
    public bool VerificarSsdCompativel(PlacaMae placaMae, Ssd ssd)
    {
        // Refatorar -> lógica específica para verificar compatibilidade
        return true; 
    }
}
