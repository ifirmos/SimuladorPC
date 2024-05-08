using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class ComponenteService<T> : IComponenteService<T> where T : Componente
{
    private readonly IBaseRepository<T> _repository;

    public ComponenteService(IBaseRepository<T> repository)
    {
        _repository = repository;
    }

    public virtual IEnumerable<T> GetAll()
    {
        return _repository.GetAll();
    }

    public virtual T GetById(int id)
    {
        return _repository.GetById(id);
    }

    public virtual T Add(T entity)
    {
        _repository.Add(entity);
        return entity;
    }

    public virtual void Update(T entity)
    {
        _repository.Update(entity);
    }

    public virtual void Delete(T entity)
    {
        _repository.Delete(entity);
    }
}
