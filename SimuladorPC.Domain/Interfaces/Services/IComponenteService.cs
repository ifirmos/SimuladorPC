using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface IComponenteService<T> where T : Componente
{
    IEnumerable<T> GetAll();
    T ObterPorId(int id);
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
