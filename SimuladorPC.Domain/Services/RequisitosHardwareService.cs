using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class RequisitosHardwareService : IRequisitosHardwareService
{
    private readonly IBaseRepository<RequisitosHardware> _repository;
    public RequisitosHardwareService(IBaseRepository<RequisitosHardware> repository)
    {
        _repository = repository;
    }

    public virtual IEnumerable<RequisitosHardware> GetAll()
    {
        return _repository.GetAll();
    }

    public virtual RequisitosHardware ObterPorId(int id)
    {
        return _repository.ObterPorId(id);
    }

    public virtual RequisitosHardware Add(RequisitosHardware entity)
    {
        _repository.Add(entity);
        return entity;
    }

    public virtual void Update(RequisitosHardware entity)
    {
        _repository.Update(entity);
    }

    public virtual void Delete(RequisitosHardware entity)
    {
        _repository.Delete(entity);
    }
}
