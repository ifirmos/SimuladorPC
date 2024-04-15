using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Domain.Interfaces.Services
{
    public interface IGabineteService
    {
        void AdicionarGabinete(Gabinete gabinete);
        IEnumerable<Gabinete> GetAllGabinetes();
        object ObterGabinetePorId(int v, int id);
        object ObterGabinetePorId(int id);
    }
}
