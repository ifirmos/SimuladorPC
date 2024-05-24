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
        .Where(cpu => cpu.PontuacaoCpuMark >= requisitoBasico.PontuacaoCpuMark)
        .OrderBy(cpu => cpu.PontuacaoCpuMark)
        .FirstOrDefault();

        return cpuCompativel ?? throw new InvalidOperationException("Nenhuma CPU encontrada para o Software informado.");
    }

    public Fonte ObterFonteAdequada(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }

    public Gabinete ObterGabineteAdequado(Software software, SetupPc setupPc)
    {
        var gabineteAdequado = context.Gabinetes
        .Where(gabinete => gabinete.Comprimento_Cm >= setupPc.Gpu.Comprimento_Cm)
        .FirstOrDefault();

        return gabineteAdequado ?? throw new InvalidOperationException("Nenhum gabinete adequado para o Setup.");
    }

    public Gpu ObterGpuCompativel(Software software, SetupPc setupPc)  
    {
        var requisitoBasico = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Basico)
            ?? throw new InvalidOperationException("Nenhum requisito básico encontrado para o software informado.");

        var gpuCompativel = context.Gpus
        .Where(gpu => gpu.PontuacaoPassMarkG3D >= requisitoBasico.PontuacaoPassMarkG3D &&
                      gpu.QtdMemoriaEmGb >= requisitoBasico.MinimoVRamGpuGb &&
                      (!requisitoBasico.TecnologiasRequeridas.Any() ||
                       requisitoBasico.TecnologiasRequeridas.All(reqTec => gpu.TecnologiasSuportadas.Contains(reqTec))))
        .OrderBy(gpu => gpu.PontuacaoPassMarkG3D)
        .FirstOrDefault();

        return gpuCompativel ?? throw new InvalidOperationException("Nenhuma GPU encontrada para o Software informado.");
    }

    public PlacaMae ObterPlacaMaeCompativel(SetupPc setupPc)
    {

        var placaMaeCompativel = context.PlacasMae
        .Where(placaMae =>
            placaMae.SocketProcessadorId == setupPc.Cpu.SocketProcessadorId && 
            placaMae.PciExpressSlots.Any(slot => slot.VersaoPcie <= setupPc.Gpu.VersaoPcie)) 
        .FirstOrDefault();

        return placaMaeCompativel ?? throw new InvalidOperationException("Nenhuma placa mãe encontrada para o Software informado.");
    }

    public Ram ObterRamCompativel(Software software, SetupPc setupPc)
    {
        var requisitoBasico = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Basico)
            ?? throw new InvalidOperationException("Nenhum requisito básico encontrado para o software informado.");

        var ramCompativel = context.Rams
        .Where(ram => ram.CapacidadeGb >= requisitoBasico.MinimoRamGb && ram.TipoMemoria == setupPc.PlacaMae.TipoMemoria)
        .FirstOrDefault();

        return ramCompativel ?? throw new InvalidOperationException("Nenhuma Ram compatível encontrada para o Software informado.");
    }

    public Software ObterSoftwarePorNome(string softwareNome)
    {
        return _entities
            .Include(s => s.Requisitos)
            .FirstOrDefault(s => s.Nome.Trim().ToLower() == softwareNome.ToLower());
    }

    public Ssd ObterSsdCompativel(Software software, SetupPc setupPc)
    {
        var requisitoBasico = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Basico)
            ?? throw new InvalidOperationException("Nenhum requisito básico encontrado para o software informado.");

        var ssdCompativel = context.Ssds
        .Where(ssd => ssd.CapacidadeGb >= requisitoBasico.MinimoArmazenamentoGb)
        .FirstOrDefault();

        return ssdCompativel ?? throw new InvalidOperationException("Nenhuma Ram compatível encontrada para o Software informado.");
    }

    public WaterCooler? ObterWaterCoolerCompativel(Software software, SetupPc setupPc)
    {
        throw new NotImplementedException();
    }
}
