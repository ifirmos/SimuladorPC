using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface IPlacaMaeService : IComponenteService<PlacaMae>
{
    PlacaMae AdicionarPlacaMae(PlacaMae placaMae);
    IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId);
}
