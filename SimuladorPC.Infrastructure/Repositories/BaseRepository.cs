using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace SimuladorPC.Infrastructure.Data;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly DbContext _context;
    protected readonly DbSet<T> _entities;

    public BaseRepository(SimuladorPcContext context)
    {
        _context = context;
        _entities = context.Set<T>();
    }

    public virtual IEnumerable<T> GetAll() => _entities;
    public virtual T GetById(int id)
    {
        return _entities.Find(id);
    }

    public virtual void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }
    public virtual void Update(T entity)
    {
        _entities.Update(entity);
        _context.SaveChanges();
    }
    public void Delete(T entity)
    {
        _entities.Remove(entity);
        _context.SaveChanges();
    }
    public bool Any(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().Any(predicate);
    }
}
