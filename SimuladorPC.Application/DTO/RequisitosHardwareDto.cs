namespace SimuladorPC.Application.DTO;

public class RequisitosHardwareDto
{
    public int Id { get; private set; }
    public double CpuImportancia { get; set; }
    public double GpuImportancia { get; set; }
    public double RamImportancia { get; set; }
    public double ArmazenamentoImportancia { get; set; }
    public int MinimoNucleosCpu { get; set; }
    public float MinimoClockGhzCpu { get; set; }
    public int MinimoVRamGpuMb { get; set; }
    public int MinimaRamGb { get; set; }
    public int MinimoArmazenamentoGb { get; set; }
    public string TipoArmazenamento { get; set; }
    public int SoftwareId { get; set; }
}  