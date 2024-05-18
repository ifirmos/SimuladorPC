using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class RequisitosHardwareDto
{
    public int Id { get; private set; }
    public int SoftwareId { get;  private set; }
    public NivelDesempenho Nivel { get;  set; }
    public IList<Tecnologias>? TecnologiasRequeridas { get;  set; }
    public double CpuImportancia { get;  set; }
    public double GpuImportancia { get;  set; }
    public double RamImportancia { get;  set; }
    public double ArmazenamentoImportancia { get;  set; }
    public int MinimoNucleosCpu { get;  set; }
    public int MinimoClockGhzCpu { get;  set; }
    public int MinimoClockGhzGpu { get;  set; }
    public int MinimoVRamGpuGb { get;  set; }
    public int MinimoRamGb { get;  set; }
    public int MinimoArmazenamentoGb { get;  set; }
    public string TipoArmazenamento { get;  set; }
}  