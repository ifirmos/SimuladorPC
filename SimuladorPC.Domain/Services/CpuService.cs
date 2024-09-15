using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services
{
    public class CpuService : ComponenteService<Cpu>, ICpuService
    {
        private readonly ICpuRepository _cpuRepository;
        private readonly IWaterCoolerRepository _waterCoolerRepository;

        public CpuService(ICpuRepository cpuRepository, IWaterCoolerRepository waterCoolerRepository) : base(cpuRepository)
        {
            _cpuRepository = cpuRepository;
            _waterCoolerRepository = waterCoolerRepository;
        }
       
        public IEnumerable<Cpu> ObterCpusCompativeis(SetupPc setupPc)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cpu> ListarCpusCompativeis(SetupPc setupPc) 
        {
            var cpus = _cpuRepository.GetAll();

            return cpus.Where(cpu =>
                setupPc.PlacaMae == null || setupPc.PlacaMae.SocketProcessador == cpu.SocketProcessador);
        }

        public IEnumerable<WaterCooler> ListarWaterCoolersCompativeis(int cpuId)
        {
            var cpu = _cpuRepository.ObterPorId(cpuId);
            var waterCoolers = _waterCoolerRepository.GetAll();
            return waterCoolers.Where(waterCooler =>
            waterCooler.SocketsSuportados.Contains(cpu.SocketProcessador));            
        }
    }
}
