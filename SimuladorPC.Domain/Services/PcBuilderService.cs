using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;
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
            setupPc.Cpu = _softwareRepository.ObterCpuCompativel(software);
            setupPc.Gpu = _softwareRepository.ObterGpuCompativel(software, setupPc);
            setupPc.PlacaMae = _softwareRepository.ObterPlacaMaeCompativel(software, setupPc);
            setupPc.Rams = _softwareRepository.ObterRamsCompativeis(software, setupPc);
            setupPc.Ssds = _softwareRepository.ObterSsdsCompativeis(software, setupPc);
            setupPc.Gabinete = _softwareRepository.ObterGabineteAdequado(software, setupPc);
            setupPc.WaterCooler = _softwareRepository.ObterWaterCoolerCompativel(software, setupPc);
            setupPc.Fonte = _softwareRepository.ObterFonteAdequada(software, setupPc);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Erro ao montar a configuração do PC: {ex.Message}", ex);
        }

        return setupPc;
    }
}
