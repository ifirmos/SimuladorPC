using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Hardware;

public class Gpu : Componente
{
    public int QtdMemoriaGb { get; private set; }
    public int PortasDisplayPort { get; private set; }
    public int PortasHdmi { get; private set; }
    public int QtdCoolers { get; private set; }
    public int PotenciaRecomendadaEmWatts { get; private set; }
    public int FrequenciaBase { get; private set; }
    public int FrequenciaMax { get; private set; }
    public IList<Tecnologias>? TecnologiasSuportadas { get; private set; }
}
