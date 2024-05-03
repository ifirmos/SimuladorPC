using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface IComponenteService<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
