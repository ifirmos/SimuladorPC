using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class SoftwareService : ISoftwareService
{
    private readonly ISoftwareRepository _softwareRepository;
    public SoftwareService(ISoftwareRepository softwareRepository)
    {
        _softwareRepository = softwareRepository;
    }

    public virtual IEnumerable<Software> GetAll()
    {
        return _softwareRepository.GetAll();
    }

    public virtual Software ObterPorId(int id)
    {
        return _softwareRepository.ObterPorId(id);
    }

    public Software AdicionarSoftware(Software software)
    {
        if (_softwareRepository.Any(p => p.Nome.Trim().ToLower() == software.Nome.Trim().ToLower()))
        {
            throw new Exception("Um software com o mesmo nome já existe.");
        }

        _softwareRepository.Add(software);
        return software;
    }

    public virtual void Update(Software entity)
    {
        _softwareRepository.Update(entity);
    }

    public virtual void Delete(Software entity)
    {
        _softwareRepository.Delete(entity);
    }

    public Software ObterSoftwarePorNome(string softwareNome)
    {
        return _softwareRepository.ObterSoftwarePorNome(softwareNome);
    }
}
