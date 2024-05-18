using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;
using SimuladorPC.Domain.Interfaces.Repositories;

namespace SimuladorPC.Infrastructure.Data;

public class SoftwareRepository(SimuladorPcContext context) : BaseRepository<Software>(context), ISoftwareRepository
{
    public override IEnumerable<Software> GetAll()
    {
        return _entities.Include(s => s.Requisitos).ToList();
    }
    public Cpu ObterCpuCompativel(Software software)
    {
        // Busca o primeiro requisito de hardware do nível básico para o software especificado
        var requisitoBasico = software.Requisitos
                                      .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Basico);

        if (requisitoBasico == null)
            return null;

        // Filtra e retorna a primeira CPU que atende ao requisito básico
        return context.Cpus
                       .FirstOrDefault(cpu => cpu.Nucleos >= requisitoBasico.MinimoNucleosCpu &&
                                              cpu.FrequenciaBaseMhz >= requisitoBasico.MinimoClockGhzCpu);
    }

    Cpu ISoftwareRepository.ObterCpuCompativel(Software software)
    {
        throw new NotImplementedException();
    }

    Fonte ISoftwareRepository.ObterFonteAdequada(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    Gabinete ISoftwareRepository.ObterGabineteAdequado(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    Gpu ISoftwareRepository.ObterGpuCompativel(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    PlacaMae ISoftwareRepository.ObterPlacaMaeCompativel(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    List<Ram> ISoftwareRepository.ObterRamsCompativeis(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    List<Ssd> ISoftwareRepository.ObterSsdsCompativeis(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    WaterCooler? ISoftwareRepository.ObterWaterCoolerCompativel(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }
}
