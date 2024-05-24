
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Software;
public class RequisitosHardware
{
    public int Id { get; private set; }
    public int SoftwareId { get; private set; }
    public virtual NivelDesempenho NivelDesempenho { get; private set; }
    public virtual IList<Tecnologias>? TecnologiasRequeridas { get; private set; }
    public int MinimoNucleosCpu { get; private set; }
    public int MinimoClockCpuMhz { get; private set; }
    public int MinimoClockGpuMhz { get; private set; }
    public int MinimoVRamGpuGb { get; private set; }
    public int MinimoRamGb { get; private set; }
    public int MinimoArmazenamentoGb { get; private set; }
    public int PontuacaoPassMarkG3D { get; private set; }
    public int PontuacaoCpuMark { get; private set; }
    public string TipoArmazenamento { get; private set; } = string.Empty;
}
