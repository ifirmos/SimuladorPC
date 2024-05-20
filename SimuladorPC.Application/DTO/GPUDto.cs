using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class GpuDto : ComponenteDto
{
    public int QtdMemoriaEmGb { get; set; }
    public int PortasDisplayPort { get; set; }
    public int PortasHdmi { get; set; }
    public int QtdCoolers { get; set; }
    public int PotenciaRecomendadaEmWatts { get; set; }
    public int FrequenciaBaseMhz { get; set; }
    public int FrequenciaMaxMhz { get; set; }
    public virtual IList<Tecnologias>? TecnologiasSuportadas { get; set; }
}
