using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class GpuDto : ComponenteDto
{
    public int QtdMemoriaGb { get; set; }
    public int PortasDisplayPort { get; set; }
    public int PortasHdmi { get; set; }
    public int QtdCoolers { get; set; }
    public int PotenciaRecomendadaEmWatts { get; set; }
    public int FrequenciaBase { get; set; }
    public int FrequenciaMax { get; set; }
    public IList<Tecnologias>? TecnologiasSuportadas { get; set; }
}
