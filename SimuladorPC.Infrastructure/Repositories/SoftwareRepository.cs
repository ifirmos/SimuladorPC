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
        return _entities.Include(s => s.Requisitos);
    }
    public Cpu ObterCpuCompativel(Software software)
    {
        var requisitoBasico = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Basico)
            ?? throw new InvalidOperationException("Nenhum requisito básico encontrado para o software informado.");
        var cpuCompativel = context.Cpus
            .FirstOrDefault(cpu => cpu.Nucleos >= requisitoBasico.MinimoNucleosCpu &&
                                   cpu.FrequenciaBaseMhz >= requisitoBasico.MinimoClockCpuMhz);

        return cpuCompativel ?? throw new InvalidOperationException("Nenhuma CPU encontrada para o Software informado.");
    }

    public Fonte ObterFonteAdequada(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    public Gabinete ObterGabineteAdequado(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    public Gpu ObterGpuCompativel(Software software, SetupPc setupPc)
    {
        var requisitoBasico = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Basico)
            ?? throw new InvalidOperationException("Nenhum requisito básico encontrado para o software informado.");

        var gpuCompativel = context.Gpus
        .FirstOrDefault(gpu => gpu.FrequenciaBaseMhz >= requisitoBasico.MinimoClockGpuMhz &&
                                gpu.QtdMemoriaEmGb >= requisitoBasico.MinimoVRamGpuGb &&
                                (requisitoBasico.TecnologiasRequeridas == null ||
                                requisitoBasico.TecnologiasRequeridas.All(reqTec => gpu.TecnologiasSuportadas.Contains(reqTec))));

        return gpuCompativel ?? throw new InvalidOperationException("Nenhuma GPU encontrada para o Software informado.");
    }

    public PlacaMae ObterPlacaMaeCompativel(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ram> ObterRamsCompativeis(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    public Software ObterSoftwarePorNome(string softwareNome)
    {
        return _entities
            .Include(s => s.Requisitos)
            .FirstOrDefault(s => s.Nome.Trim().ToLower() == softwareNome.ToLower());
    }

    public IEnumerable<Ssd> ObterSsdsCompativeis(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    public WaterCooler? ObterWaterCoolerCompativel(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }
}
