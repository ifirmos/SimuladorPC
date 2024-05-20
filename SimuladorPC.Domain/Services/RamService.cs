using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class RamService : ComponenteService<Ram>, IRamService
{
    private readonly IRamRepository _ramRepository;

    public RamService(IRamRepository ramRepository) : base(ramRepository)
    {
        _ramRepository = ramRepository;
    }

    public override Ram Add(Ram ram)
    {
        if (_ramRepository.Any(r => r.Modelo.Trim().ToLower() == ram.Nome.Trim().ToLower()))
        {
            throw new Exception("Uma memória com o mesmo nome já existe.");
        }

        var existingTipoRam = _ramRepository.Find(r => r.TipoMemoria.Tipo == ram.TipoMemoria.Tipo);
        if (existingTipoRam != null)
        {
            ram.SetTipoRam(existingTipoRam.TipoMemoria);
        }

        _ramRepository.Add(ram);
        return ram;
    }
}
