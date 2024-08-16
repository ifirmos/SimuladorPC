using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;
using SimuladorPC.Domain.Interfaces.Repositories;

namespace SimuladorPC.Infrastructure.Data;

public class RequisitosHardwareRepository : BaseRepository<RequisitosHardware>, IRequisitosHardwareRepository
{
    private readonly SimuladorPcContext _context;

    public RequisitosHardwareRepository(SimuladorPcContext context) : base(context)
    {
        _context = context;
    }

    public Cpu ObterCpuCompativel(RequisitosHardware requisitos)
    {
        var cpuCompativel = _context.Cpus
            .Where(cpu => cpu.PontuacaoCpuMark >= requisitos.PontuacaoCpuMark)
            .OrderBy(cpu => cpu.PontuacaoCpuMark)
            .FirstOrDefault();

        return cpuCompativel ?? throw new InvalidOperationException("Nenhuma CPU encontrada para os requisitos informados.");
    }

    public IEnumerable<Cpu> ListarCpusCompativeis(RequisitosHardware requisitos)
    {
        return _context.Cpus
            .Where(cpu => cpu.PontuacaoCpuMark >= requisitos.PontuacaoCpuMark)
            .OrderBy(cpu => cpu.PontuacaoCpuMark)
            .ToList();
    }

    public Gpu ObterGpuCompativel(RequisitosHardware requisitos, SetupPc setupPc)
    {
        var gpuCompativel = _context.Gpus
            .Where(gpu => gpu.PontuacaoPassMarkG3D >= requisitos.PontuacaoPassMarkG3D &&
                          gpu.QtdMemoriaEmGb >= requisitos.MinimoVRamGpuGb &&
                          (requisitos.TecnologiasRequeridas == null ||
                           !requisitos.TecnologiasRequeridas.Any() ||
                           requisitos.TecnologiasRequeridas.All(reqTec => gpu.TecnologiasSuportadas.Contains(reqTec))))
            .OrderBy(gpu => gpu.PontuacaoPassMarkG3D)
            .FirstOrDefault();

        return gpuCompativel ?? throw new InvalidOperationException("Nenhuma GPU encontrada para os requisitos informados.");
    }

    public IEnumerable<Gpu> ListarGpusCompativeis(RequisitosHardware requisitos, SetupPc setupPc)
    {
        return _context.Gpus
            .Where(gpu => gpu.PontuacaoPassMarkG3D >= requisitos.PontuacaoPassMarkG3D &&
                          gpu.QtdMemoriaEmGb >= requisitos.MinimoVRamGpuGb &&
                          (requisitos.TecnologiasRequeridas == null ||
                           !requisitos.TecnologiasRequeridas.Any() ||
                           requisitos.TecnologiasRequeridas.All(reqTec => gpu.TecnologiasSuportadas.Contains(reqTec))))
            .OrderBy(gpu => gpu.PontuacaoPassMarkG3D)
            .ToList();
    }

    public PlacaMae ObterPlacaMaeCompativel(RequisitosHardware requisitos, SetupPc setupPc)
    {
        var placaMaeCompativel = _context.PlacasMae
            .Where(placaMae =>
                placaMae.SocketProcessador == setupPc.Cpu.SocketProcessador &&
                placaMae.PciExpressSlots.Any(slot => slot.VersaoPcie <= setupPc.Gpu.VersaoPcie))
            .FirstOrDefault();

        return placaMaeCompativel ?? throw new InvalidOperationException("Nenhuma placa mãe encontrada para os requisitos informados.");
    }

    public IEnumerable<PlacaMae> ListarPlacasMaeCompativeis(RequisitosHardware requisitos, SetupPc setupPc)
    {
        return _context.PlacasMae
            .Where(placaMae =>
                placaMae.SocketProcessador == setupPc.Cpu.SocketProcessador &&
                placaMae.PciExpressSlots.Any(slot => slot.VersaoPcie <= setupPc.Gpu.VersaoPcie))
            .ToList();
    }

    public Ram ObterRamCompativel(RequisitosHardware requisitos, SetupPc setupPc)
    {
        var ramCompativel = _context.Rams
            .Where(ram => ram.CapacidadeGb >= requisitos.MinimoRamGb && ram.TipoMemoria == setupPc.PlacaMae.TipoMemoria)
            .FirstOrDefault();

        return ramCompativel ?? throw new InvalidOperationException("Nenhuma Ram compatível encontrada para os requisitos informados.");
    }

    public IEnumerable<Ram> ListarRamsCompativeis(RequisitosHardware requisitos, SetupPc setupPc)
    {
        return _context.Rams
            .Where(ram => ram.CapacidadeGb >= requisitos.MinimoRamGb && ram.TipoMemoria == setupPc.PlacaMae.TipoMemoria)
            .ToList();
    }

    public Ssd ObterSsdCompativel(RequisitosHardware requisitos, SetupPc setupPc)
    {
        var ssdCompativel = _context.Ssds
            .Where(ssd => ssd.CapacidadeGb >= requisitos.MinimoArmazenamentoGb)
            .FirstOrDefault();

        return ssdCompativel ?? throw new InvalidOperationException("Nenhum Ssd compatível encontrado para os requisitos informados.");
    }

    public IEnumerable<Ssd> ListarSsdsCompativeis(RequisitosHardware requisitos, SetupPc setupPc)
    {
        return _context.Ssds
            .Where(ssd => ssd.CapacidadeGb >= requisitos.MinimoArmazenamentoGb)
            .ToList();
    }

    public WaterCooler ObterWaterCoolerCompativel(RequisitosHardware requisitos, SetupPc setupPc)
    {
        var waterCoolerCompativel = _context.WaterCoolers
            .Where(wc => wc.TdpMaximo >= setupPc.Cpu.Tdp &&
                         wc.SocketsSuportados.Any(socket => socket == setupPc.Cpu.SocketProcessador))
            .FirstOrDefault();

        return waterCoolerCompativel ?? throw new InvalidOperationException("Nenhum Watercooler compatível encontrado para os requisitos informados.");
    }

    public IEnumerable<WaterCooler> ListarWaterCoolersCompativeis(RequisitosHardware requisitos, SetupPc setupPc)
    {
        return _context.WaterCoolers
            .Where(wc => wc.TdpMaximo >= setupPc.Cpu.Tdp &&
                         wc.SocketsSuportados.Any(socket => socket == setupPc.Cpu.SocketProcessador))
            .ToList();
    }

    public Gabinete ObterGabineteAdequado(RequisitosHardware requisitos, SetupPc setupPc)
    {
        var gabineteAdequado = _context.Gabinetes
            .Where(gabinete => gabinete.Comprimento_Cm >= setupPc.Gpu.Comprimento_Cm &&
                    gabinete.SuporteRadiador_mm >= setupPc.WaterCooler.TamanhoRadiador_mm)
            .FirstOrDefault();

        return gabineteAdequado ?? throw new InvalidOperationException("Nenhum gabinete adequado encontrado para os requisitos informados.");
    }

    public IEnumerable<Gabinete> ListarGabinetesAdequados(RequisitosHardware requisitos, SetupPc setupPc)
    {
        return _context.Gabinetes
            .Where(gabinete => gabinete.Comprimento_Cm >= setupPc.Gpu.Comprimento_Cm &&
                    gabinete.SuporteRadiador_mm >= setupPc.WaterCooler.TamanhoRadiador_mm)
            .ToList();
    }

    public Fonte ObterFonteAdequada(SetupPc setupPc)
    {
        var fonteAdequada = _context.Fontes
            .Where(fonte => fonte.Potencia >= setupPc.ConsumoMaximoTotalEmWatts)
            .OrderBy(fonte => fonte.Potencia)
            .FirstOrDefault();

        return fonteAdequada ?? throw new InvalidOperationException("Nenhuma fonte adequada encontrada para os requisitos informados.");
    }

    public IEnumerable<Fonte> ListarFontesAdequadas(SetupPc setupPc)
    {
        return _context.Fontes
            .Where(fonte => fonte.Potencia >= setupPc.ConsumoMaximoTotalEmWatts)
            .OrderBy(fonte => fonte.Potencia)
            .ToList();
    }
}
