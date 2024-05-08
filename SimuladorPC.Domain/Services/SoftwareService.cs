using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class SoftwareService : ISoftwareService
{
    private readonly IBaseRepository<Software> _repository;
    public SoftwareService(IBaseRepository<Software> repository)
    {
        _repository = repository;
    }

    public virtual IEnumerable<Software> GetAll()
    {
        return _repository.GetAll();
    }

    public virtual Software GetById(int id)
    {
        return _repository.GetById(id);
    }

    public virtual Software Add(Software entity)
    {
        _repository.Add(entity);
        return entity;
    }

    public virtual void Update(Software entity)
    {
        _repository.Update(entity);
    }

    public virtual void Delete(Software entity)
    {
        _repository.Delete(entity);
    }
}
