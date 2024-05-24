using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class RequisitosHardwareDto
{
    public int Id { get; private set; }
    public int SoftwareId { get; set; }
    public virtual NivelDesempenho NivelDesempenho { get; set; }
    public virtual IList<Tecnologias>? TecnologiasRequeridas { get; set; }
    public int MinimoNucleosCpu { get; set; }
    public int MinimoClockCpuMhz { get; set; }
    public int MinimoClockGpuMhz { get; set; }
    public int MinimoVRamGpuGb { get; set; }
    public int MinimoRamGb { get; set; }
    public int MinimoArmazenamentoGb { get; set; }
    public int PontuacaoPassMarkG3D { get; set; }
    public int PontuacaoCpuMark { get; set; }
    public string TipoArmazenamento { get; set; }
}  