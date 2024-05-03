using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Application.DTO;

public class GpuDto : ComponenteDto
{
    public int QtdMemoria { get; set; }
    public int PortasDisplayPort { get; set; }
    public int PortasHdmi { get; set; }
    public int QtdCoolers { get; set; }
    public int PotenciaRecomendada { get; set; }
    public float FrequenciaBase { get; set; }
    public float FrequenciaMax { get; set; }
}
