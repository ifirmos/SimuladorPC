using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class PcBuilderService : IPcBuilderService
{
    private readonly ISoftwareRepository _softwareRepository;

    public PcBuilderService(ISoftwareRepository softwareRepository)
    {
        _softwareRepository = softwareRepository;
    }

    public SetupPc AutoBuildPcConfiguration(Software software)
    {
        var setupPc = new SetupPc();
        try
        {
            setupPc.Cpu = ObterCpuCompativel(software);

            setupPc.Gpu = ObterGpuCompativel(software, setupPc);

            setupPc.PlacaMae = ObterPlacaMaeCompativel(software, setupPc);

            setupPc.Rams = ObterRamsCompativeis(software, setupPc);

            setupPc.Ssds = ObterSsdsCompativeis(software, setupPc);

            setupPc.Gabinete = ObterGabineteAdequado(software, setupPc);

            setupPc.WaterCooler = ObterWaterCoolerCompativel(software, setupPc);

            setupPc.Fonte = ObterFonteAdequada(software, setupPc);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Erro ao montar a configuração do PC: {ex.Message}", ex);
        }

        return setupPc;
    }
    private Cpu ObterCpuCompativel(Software software)
    {
        var cpu = _softwareRepository.ObterCpuCompativel(software);
        if (cpu == null) throw new InvalidOperationException("Nenhuma CPU compatível encontrada.");
        return cpu;
    }

    private Gpu ObterGpuCompativel(Software software, SetupPc setupPc)
    {
        var gpu = _softwareRepository.ObterGpuCompativel(software, setupPc);
        if (gpu == null) throw new InvalidOperationException("Nenhuma GPU compatível encontrada.");
        return gpu;
    }

    private PlacaMae ObterPlacaMaeCompativel(Software software, SetupPc setupPc)
    {
        var placaMae = _softwareRepository.ObterPlacaMaeCompativel(software, setupPc);
        if (placaMae == null) throw new InvalidOperationException("Nenhuma Placa Mãe compatível encontrada.");
        return placaMae;
    }

    private IEnumerable<Ram> ObterRamsCompativeis(Software software, SetupPc setupPc)
    {
        var rams = _softwareRepository.ObterRamsCompativeis(software, setupPc);
        if (!rams.Any()) throw new InvalidOperationException("Nenhuma RAM compatível encontrada.");
        return rams;
    }

    private IEnumerable<Ssd> ObterSsdsCompativeis(Software software, SetupPc setupPc)
    {
        var ssds = _softwareRepository.ObterSsdsCompativeis(software, setupPc);
        if (!ssds.Any()) throw new InvalidOperationException("Nenhum SSD compatível encontrado.");
        return ssds;
    }

    private Gabinete ObterGabineteAdequado(Software software, SetupPc setupPc)
    {
        var gabinete = _softwareRepository.ObterGabineteAdequado(software, setupPc);
        if (gabinete == null) throw new InvalidOperationException("Nenhum Gabinete adequado encontrado.");
        return gabinete;
    }

    private WaterCooler ObterWaterCoolerCompativel(Software software, SetupPc setupPc)
    {
        var waterCooler = _softwareRepository.ObterWaterCoolerCompativel(software, setupPc);
        if (waterCooler == null) throw new InvalidOperationException("Nenhum WaterCooler compatível encontrado.");
        return waterCooler;
    }

    private Fonte ObterFonteAdequada(Software software, SetupPc setupPc)
    {
        var fonte = _softwareRepository.ObterFonteAdequada(software, setupPc);
        if (fonte == null) throw new InvalidOperationException("Nenhuma Fonte adequada encontrada.");
        return fonte;
    }

}
