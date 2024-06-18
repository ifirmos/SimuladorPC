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
        var requisitoIntermediario = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Intermediario);

        var cpuCompativel = context.Cpus
        .Where(cpu => cpu.PontuacaoCpuMark >= requisitoIntermediario.PontuacaoCpuMark)
        .OrderBy(cpu => cpu.PontuacaoCpuMark)
        .FirstOrDefault();

        return cpuCompativel ?? throw new InvalidOperationException("Nenhuma CPU encontrada para o Software informado.");
    }

    public Gpu ObterGpuCompativel(Software software, SetupPc setupPc)
    {
        var requisitoIntermediario = software.Requisitos
        .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Intermediario);

        var gpuCompativel = context.Gpus
        .Where(gpu => gpu.PontuacaoPassMarkG3D >= requisitoIntermediario.PontuacaoPassMarkG3D &&
                      gpu.QtdMemoriaEmGb >= requisitoIntermediario.MinimoVRamGpuGb &&
                      (requisitoIntermediario.TecnologiasRequeridas == null ||
                       !requisitoIntermediario.TecnologiasRequeridas.Any() ||
                       requisitoIntermediario.TecnologiasRequeridas.All(reqTec => gpu.TecnologiasSuportadas.Contains(reqTec))))
        .OrderBy(gpu => gpu.PontuacaoPassMarkG3D)
        .FirstOrDefault();


        return gpuCompativel ?? throw new InvalidOperationException("Nenhuma GPU encontrada para o Software informado.");
    }

    public PlacaMae ObterPlacaMaeCompativel(SetupPc setupPc)
    {

        var placaMaeCompativel = context.PlacasMae
        .Where(placaMae =>
            placaMae.SocketProcessador == setupPc.Cpu.SocketProcessador &&
            placaMae.PciExpressSlots.Any(slot => slot.VersaoPcie <= setupPc.Gpu.VersaoPcie))
        .FirstOrDefault();

        return placaMaeCompativel ?? throw new InvalidOperationException("Nenhuma placa mãe encontrada para o Software informado.");
    }

    public Ram ObterRamCompativel(Software software, SetupPc setupPc)
    {
        var requisitoIntermediario = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Intermediario);


        var ramCompativel = context.Rams
        .Where(ram => ram.CapacidadeGb >= requisitoIntermediario.MinimoRamGb && ram.TipoMemoria.Id == setupPc.PlacaMae.TipoMemoriaId)
        .FirstOrDefault();

        return ramCompativel ?? throw new InvalidOperationException("Nenhuma Ram compatível encontrada para o Software informado.");
    }

    public Ssd ObterSsdCompativel(Software software, SetupPc setupPc)
    {
        var requisitoIntermediario = software.Requisitos
            .FirstOrDefault(r => r.NivelDesempenho == NivelDesempenho.Intermediario);


        var ssdCompativel = context.Ssds
        .Where(ssd => ssd.CapacidadeGb >= requisitoIntermediario.MinimoArmazenamentoGb)
        .FirstOrDefault();

        return ssdCompativel ?? throw new InvalidOperationException("Nenhum Ssd compatível para o setup atual.");
    }

    public WaterCooler ObterWaterCoolerCompativel(SetupPc setupPc)
    {
        var waterCoolerCompativel = context.WaterCoolers
        .Where(wc => wc.TdpMaximo >= setupPc.Cpu.Tdp &&
                     wc.SocketsSuportados.Any(socket => socket == setupPc.Cpu.SocketProcessador))
        .FirstOrDefault();

        return waterCoolerCompativel ?? throw new InvalidOperationException("Nenhum Watercooler compatível para o setup informado.");
    }

    public Gabinete ObterGabineteAdequado(SetupPc setupPc)
    {
        var gabineteAdequado = context.Gabinetes
        .Where(gabinete => gabinete.Comprimento_Cm >= setupPc.Gpu.Comprimento_Cm &&
                gabinete.SuporteRadiador_mm >= setupPc.WaterCooler.TamanhoRadiador_mm)
        .FirstOrDefault();

        return gabineteAdequado ?? throw new InvalidOperationException("Nenhum gabinete adequado para o Setup.");
    }

    public Fonte ObterFonteAdequada(SetupPc setupPc)
    {
        var fonteAdequada = context.Fontes
        .Where(fonte => fonte.Potencia >= setupPc.ConsumoMaximoTotalEmWatts)
        .OrderBy(Fonte => Fonte.Potencia)
        .FirstOrDefault();

        return fonteAdequada ?? throw new InvalidOperationException("Nenhuma fonte adequada para o Setup.");
    }
    public Software ObterSoftwarePorNome(string softwareNome)
    {
        if (string.IsNullOrWhiteSpace(softwareNome))
        {
            throw new ArgumentException("O nome do software não pode ser nulo ou vazio.", nameof(softwareNome));
        }

        var software = _entities
            .Include(s => s.Requisitos)
            .FirstOrDefault(s => s.Nome.Trim().ToLower() == softwareNome.ToLower());

        return software ?? throw new InvalidOperationException($"Nenhum software encontrado com o nome '{softwareNome}'.");
    }
}
