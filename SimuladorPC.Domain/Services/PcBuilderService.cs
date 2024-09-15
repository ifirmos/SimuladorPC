using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class PcBuilderService : IPcBuilderService
{
    private readonly ISoftwareRepository _softwareRepository;
    private readonly IRequisitosHardwareRepository _requisitosHardwareRepository;

    public PcBuilderService(ISoftwareRepository softwareRepository, IRequisitosHardwareRepository requisitosHardwareRepository)
    {
        _softwareRepository = softwareRepository;
        _requisitosHardwareRepository = requisitosHardwareRepository;
    }

    public SetupPc AutoBuildPcConfiguration(Software software)
    {
        var setupPc = new SetupPc();
        try
        {
            setupPc.Cpu = ObterCpuCompativel(software);
            setupPc.Gpu = ObterGpuCompativel(software, setupPc);
            setupPc.PlacaMae = ObterPlacaMaeCompativel(software, setupPc);
            setupPc.Ram = ObterRamsCompativeis(software, setupPc);
            setupPc.Ssd = ObterSsdsCompativeis(software, setupPc);
            setupPc.WaterCooler = ObterWaterCoolerCompativel(software, setupPc);
            setupPc.Gabinete = ObterGabineteAdequado(software, setupPc);
            CalcularConsumoTotalWatts(setupPc);
            setupPc.Fonte = ObterFonteAdequada(setupPc);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Erro ao montar a configuração do PC: {ex.Message}", ex);
        }
        return setupPc;
    }

    public SetupPc AutoBuildPcConfiguration(RequisitosHardware requisito)
    {
        var setupPc = new SetupPc();
        try
        {
            setupPc.Cpu = ObterCpuCompativel(requisito);
            setupPc.Gpu = ObterGpuCompativel(requisito, setupPc);
            setupPc.PlacaMae = ObterPlacaMaeCompativel(requisito, setupPc);
            setupPc.Ram= ObterRamsCompativeis(requisito, setupPc);
            setupPc.Ssd = ObterSsdsCompativeis(requisito, setupPc);
            setupPc.WaterCooler = ObterWaterCoolerCompativel(requisito, setupPc);
            setupPc.Gabinete = ObterGabineteAdequado(requisito, setupPc);
            CalcularConsumoTotalWatts(setupPc);
            setupPc.Fonte = ObterFonteAdequada(setupPc);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Erro ao montar a configuração do PC: {ex.Message}", ex);
        }
        return setupPc;
    }

    private static void CalcularConsumoTotalWatts(SetupPc setupPc)
    {
        int consumoTotal = 0;

        consumoTotal += setupPc.Cpu?.ConsumoEmWatts ?? 0;
        consumoTotal += setupPc.Gpu?.ConsumoEmWatts ?? 0;
        consumoTotal += setupPc.PlacaMae?.ConsumoEmWatts ?? 0;
        consumoTotal += setupPc.Ram?.ConsumoEmWatts ?? 0;
        consumoTotal += setupPc.Ssd?.ConsumoEmWatts ?? 0;
        consumoTotal += setupPc.WaterCooler?.ConsumoEmWatts ?? 0;
        consumoTotal += setupPc.Gabinete?.ConsumoEmWatts ?? 0;

        setupPc.ConsumoMaximoTotalEmWatts = consumoTotal;
    }
    private Cpu ObterCpuCompativel(Software software)
    {
        var cpu = _softwareRepository.ObterCpuCompativel(software);
        if (cpu == null) throw new InvalidOperationException("Nenhuma CPU compatível encontrada.");
        return cpu;
    }

    private Cpu ObterCpuCompativel(RequisitosHardware requisito)
    {
        var cpu = _requisitosHardwareRepository.ObterCpuCompativel(requisito);
        if (cpu == null) throw new InvalidOperationException("Nenhuma CPU compatível encontrada.");
        return cpu;
    }
    private Gpu ObterGpuCompativel(Software software, SetupPc setupPc)
{
    var gpu = _softwareRepository.ObterGpuCompativel(software, setupPc);
    if (gpu == null) throw new InvalidOperationException("Nenhuma GPU compatível encontrada.");
    return gpu;
}

    private Gpu ObterGpuCompativel(RequisitosHardware requisito, SetupPc setupPc)
    {
        var gpu = _requisitosHardwareRepository.ObterGpuCompativel(requisito, setupPc);
        if (gpu == null) throw new InvalidOperationException("Nenhuma GPU compatível encontrada.");
        return gpu;
    }

    private PlacaMae ObterPlacaMaeCompativel(Software software, SetupPc setupPc)
    {
        var placaMae = _softwareRepository.ObterPlacaMaeCompativel(setupPc);
        if (placaMae == null) throw new InvalidOperationException("Nenhuma Placa Mãe compatível encontrada.");
        return placaMae;
    }

    private PlacaMae ObterPlacaMaeCompativel(RequisitosHardware requisito, SetupPc setupPc)
    {
        var placaMae = _requisitosHardwareRepository.ObterPlacaMaeCompativel(requisito, setupPc);
        if (placaMae == null) throw new InvalidOperationException("Nenhuma Placa Mãe compatível encontrada.");
        return placaMae;
    }

    private Ram ObterRamsCompativeis(Software software, SetupPc setupPc)
    {
        var ram = _softwareRepository.ObterRamCompativel(software, setupPc);
        return ram;
    }

    private Ram ObterRamsCompativeis(RequisitosHardware requisito, SetupPc setupPc)
    {
        var ram = _requisitosHardwareRepository.ObterRamCompativel(requisito, setupPc);
        return ram;
    }

    private Ssd ObterSsdsCompativeis(Software software, SetupPc setupPc)
    {
        var ssd = _softwareRepository.ObterSsdCompativel(software, setupPc);
        return ssd;
    }

    private Ssd ObterSsdsCompativeis(RequisitosHardware requisito, SetupPc setupPc)
    {
        var ssd = _requisitosHardwareRepository.ObterSsdCompativel(requisito, setupPc);
        return ssd;
    }

    private Gabinete ObterGabineteAdequado(Software software, SetupPc setupPc)
    {
        var gabinete = _softwareRepository.ObterGabineteAdequado(setupPc);
        if (gabinete == null) throw new InvalidOperationException("Nenhum Gabinete adequado encontrado.");
        return gabinete;
    }

    private Gabinete ObterGabineteAdequado(RequisitosHardware requisito, SetupPc setupPc)
    {
        var gabinete = _requisitosHardwareRepository.ObterGabineteAdequado(requisito, setupPc);
        if (gabinete == null) throw new InvalidOperationException("Nenhum Gabinete adequado encontrado.");
        return gabinete;
    }

    private WaterCooler ObterWaterCoolerCompativel(Software software, SetupPc setupPc)
    {
        var waterCooler = _softwareRepository.ObterWaterCoolerCompativel(setupPc);
        if (waterCooler == null) throw new InvalidOperationException("Nenhum WaterCooler compatível encontrado.");
        return waterCooler;
    }

    private WaterCooler ObterWaterCoolerCompativel(RequisitosHardware requisito, SetupPc setupPc)
    {
        var waterCooler = _requisitosHardwareRepository.ObterWaterCoolerCompativel(requisito, setupPc);
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
