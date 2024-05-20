
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Software;
public class RequisitosHardware
{
    public int Id { get; private set; }
    public int SoftwareId { get; private set; }
    public virtual Software Software { get; private set; }
    public virtual NivelDesempenho NivelDesempenho { get; private set; }
    public virtual IList<Tecnologias>? TecnologiasRequeridas { get; private set; }
    public double CpuImportancia { get; private set; }
    public double GpuImportancia { get; private set; }
    public double RamImportancia { get; private set; }
    public double ArmazenamentoImportancia { get; private set; }
    public int MinimoNucleosCpu { get; private set; }
    public int MinimoClockCpuMhz { get; private set; }
    public int MinimoClockGpuMhz { get; private set; }
    public int MinimoVRamGpuGb { get; private set; }
    public int MinimoRamGb { get; private set; }
    public int MinimoArmazenamentoGb { get; private set; }
    public string TipoArmazenamento { get; private set; }
}
