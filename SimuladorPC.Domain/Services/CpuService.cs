using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services
{
    public class CpuService : ComponenteService<Cpu>, ICpuService
    {
        private readonly ICpuRepository _cpuRepository;

        public CpuService(ICpuRepository cpuRepository) : base(cpuRepository)
        {
            _cpuRepository = cpuRepository;
        }

        public IEnumerable<Cpu> ObterCpusCompativeis(SetupPc setupPc)
        {
            var cpus = _cpuRepository.GetAll();

            return cpus.Where(cpu =>
                setupPc.PlacaMae == null || setupPc.PlacaMae.SocketProcessador == cpu.SocketProcessador);
        }
    }
}
