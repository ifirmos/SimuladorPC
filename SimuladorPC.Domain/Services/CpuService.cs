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
    public IEnumerable<Cpu> ObterCpusCompativeis(SetupPc setupPc)
    {
        var cpus = _cpuRepository.GetAll();

        return cpus.Where(cpu =>
            setupPc.PlacaMae == null || setupPc.PlacaMae.SocketProcessador.Equals(cpu.Socket));
    }
}


