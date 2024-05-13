using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Hardware;

public class Gpu : Componente
{
    public int QtdMemoria { get; set; }
    public int PortasDisplayPort { get; set; }
    public int PortasHdmi { get; set; }
    public int QtdCoolers { get; set; }
    public int PotenciaRecomendada { get; set; }
    public float FrequenciaBase { get; set; }
    public float FrequenciaMax { get; set; }
    public int ChipsetId { get; set; }
    public IList<Tecnologias> Tecnologias { get; set; }
}
