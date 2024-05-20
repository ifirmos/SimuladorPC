using System.Linq.Expressions;
namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IBaseRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    bool Any(Expression<Func<T, bool>> predicate);
    public T Find(Expression<Func<T, bool>> predicate);
}

