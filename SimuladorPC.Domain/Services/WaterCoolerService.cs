using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SimuladorPC.Domain.Services
{
    public class WaterCoolerService : ComponenteService<WaterCooler>, IWaterCoolerService
    {
        private readonly IWaterCoolerRepository _waterCoolerRepository;

        public WaterCoolerService(IWaterCoolerRepository waterCoolerRepository)
            : base(waterCoolerRepository)
        {
            _waterCoolerRepository = waterCoolerRepository;
        }

        public WaterCooler AdicionarWaterCooler(WaterCooler waterCooler)
        {
            if (_waterCoolerRepository.Any(wc => wc.Nome.Trim().ToLower() == waterCooler.Nome.Trim().ToLower()))
            {
                throw new Exception("Um water cooler com o mesmo nome já existe.");
            }

            var socketsExistentes = waterCooler.SocketsSuportados
                .Where(socket => Enum.IsDefined(typeof(SocketProcessador), socket))
                .ToList();

            waterCooler.SocketsSuportados.Clear();

            foreach (var socket in socketsExistentes)
            {
                if (!waterCooler.SocketsSuportados.Contains(socket))
                {
                    waterCooler.AddSocketProcessador(socket);
                }
            }

            _waterCoolerRepository.Add(waterCooler);
            return waterCooler;
        }

        public bool VerificarCpuCompativel(WaterCooler waterCooler, Cpu cpu)
        {
            return waterCooler.SocketsSuportados.Contains(cpu.SocketProcessador);
        }

        public IEnumerable<WaterCooler> BuscarPorSocket(SocketProcessador socket)
        {
            return _waterCoolerRepository.GetAll()
                .Where(wc => wc.SocketsSuportados.Contains(socket));
        }
    }
}
