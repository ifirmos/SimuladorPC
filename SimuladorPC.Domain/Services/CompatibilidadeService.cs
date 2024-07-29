using SimuladorPC.Domain.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPC.Domain.Services;

public class CompatibilidadeService
{
    private readonly List<Gpu> _gpus;
    private readonly List<Cpu> _cpus;
    private readonly List<PlacaMae> _placasMae;
    private readonly List<Ram> _rams;
    private readonly List<dynamic> _compatibilidades;

    public CompatibilidadeService(List<Gpu> gpus, List<Cpu> cpus, List<PlacaMae> placasMae, List<Ram> rams, List<dynamic> compatibilidades)
    {
        _gpus = gpus;
        _cpus = cpus;
        _placasMae = placasMae;
        _rams = rams;
        _compatibilidades = compatibilidades;
    }

    public List<PlacaMae> ObterPlacasMaeCompativeisComGpu(int gpuId)
    {
        var compatibilidadesGpu = _compatibilidades.Where(c => c.ComponenteAId == gpuId && c.TipoComponenteA == "Gpu" && c.TipoComponenteB == "PlacaMae");
        return _placasMae.Where(pm => compatibilidadesGpu.Any(c => c.ComponenteBId == pm.Id)).ToList();
    }

    public List<PlacaMae> ObterPlacasMaeCompativeisComCpu(int cpuId)
    {
        var compatibilidadesCpu = _compatibilidades.Where(c => c.ComponenteAId == cpuId && c.TipoComponenteA == "Cpu" && c.TipoComponenteB == "PlacaMae");
        return _placasMae.Where(pm => compatibilidadesCpu.Any(c => c.ComponenteBId == pm.Id)).ToList();
    }

    public List<Ram> ObterRamsCompativeisComPlacaMae(int placaMaeId)
    {
        var compatibilidadesPlacaMae = _compatibilidades.Where(c => c.ComponenteAId == placaMaeId && c.TipoComponenteA == "PlacaMae" && c.TipoComponenteB == "Ram");
        return _rams.Where(r => compatibilidadesPlacaMae.Any(c => c.ComponenteBId == r.Id)).ToList();
    }
}

