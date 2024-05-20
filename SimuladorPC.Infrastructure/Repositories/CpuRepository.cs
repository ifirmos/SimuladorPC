using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Infrastructure.Data;

namespace SimuladorPC.Infrastructure.Repositories;

public class CpuRepository : BaseRepository<Cpu>, ICpuRepository
{
    public CpuRepository(SimuladorPcContext context) : base(context)
    {
    }

    public override IEnumerable<Cpu> GetAll()
    {
        // Eager loading da entidade relacionada SocketProcessador
        return _entities
            .Include(c => c.Socket)
            .ToList(); // Força a execução da consulta para carregar todos os dados
    }

    public override Cpu GetById(int id)
    {
        // Eager loading da entidade relacionada Socket
        return _entities
            .Include(c => c.Socket)
            .SingleOrDefault(c => c.Id == id);
    }
    public IEnumerable<Cpu> ObterCPUsCompativeisPorSocket(string socketType)
    {
        return _entities.Where(cpu => cpu.Socket.Nome == socketType);
    }
}

