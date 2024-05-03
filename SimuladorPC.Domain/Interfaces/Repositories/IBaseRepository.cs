using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IBaseRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}

