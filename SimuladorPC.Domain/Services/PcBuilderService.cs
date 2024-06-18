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

            setupPc.Rams.Add(ObterRamsCompativeis(software, setupPc));

            setupPc.Ssds.Add(ObterSsdsCompativeis(software, setupPc));

            setupPc.WaterCooler = ObterWaterCoolerCompativel(software, setupPc);

            setupPc.Gabinete = ObterGabineteAdequado(software, setupPc);

            setupPc.Fonte = ObterFonteAdequada(setupPc);
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
        var placaMae = _softwareRepository.ObterPlacaMaeCompativel(setupPc);
        if (placaMae == null) throw new InvalidOperationException("Nenhuma Placa Mãe compatível encontrada.");
        return placaMae;
    }

    private Ram ObterRamsCompativeis(Software software, SetupPc setupPc)
    {
        var ram = _softwareRepository.ObterRamCompativel(software, setupPc);
        return ram;
    }

    private Ssd ObterSsdsCompativeis(Software software, SetupPc setupPc)
    {
        var ssd = _softwareRepository.ObterSsdCompativel(software, setupPc);
        return ssd;
    }

    private Gabinete ObterGabineteAdequado(Software software, SetupPc setupPc)
    {
        var gabinete = _softwareRepository.ObterGabineteAdequado(setupPc);
        if (gabinete == null) throw new InvalidOperationException("Nenhum Gabinete adequado encontrado.");
        return gabinete;
    }

    private WaterCooler ObterWaterCoolerCompativel(Software software, SetupPc setupPc)
    {
        var waterCooler = _softwareRepository.ObterWaterCoolerCompativel(setupPc);
        if (waterCooler == null) throw new InvalidOperationException("Nenhum WaterCooler compatível encontrado.");
        return waterCooler;
    }

    private Fonte ObterFonteAdequada(SetupPc setupPc)
    {
        var fonte = _softwareRepository.ObterFonteAdequada(setupPc);
        if (fonte == null) throw new InvalidOperationException("Nenhuma Fonte adequada encontrada.");
        return fonte;
    }

}
