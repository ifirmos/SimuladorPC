using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;
using System.Net.Sockets;

namespace SimuladorPC.Domain.Services;

public class CpuService : ComponenteService<Cpu>, ICpuService
{
    private readonly ICpuRepository _cpuRepository;
    private readonly ISocketProcessadorRepository _socketRepository;

    public CpuService(ICpuRepository cpuRepository, ISocketProcessadorRepository socketRepository) : base(cpuRepository)
    {
        _cpuRepository = cpuRepository;
        _socketRepository = socketRepository;
    }

    public override Cpu Add(Cpu cpu)
    {
        var existingSocket = _socketRepository.Find(s => s.Nome.Trim().ToLower() == cpu.Socket.Nome.Trim().ToLower());
        if (existingSocket != null)
        {
            cpu.SetSocket(existingSocket);
        }

        _cpuRepository.Add(cpu);
        return cpu;
    }
    public IEnumerable<Cpu> ObterCPUsCompativeisPorSocket(string tipoSocket)
    {
        return _cpuRepository.ObterCPUsCompativeisPorSocket(tipoSocket);
    }
    public override IEnumerable<Cpu> GetAll()
    {
        return _cpuRepository.GetAll();
    }

    public override Cpu GetById(int id)
    {
        return _cpuRepository.GetById(id);
    }
}


