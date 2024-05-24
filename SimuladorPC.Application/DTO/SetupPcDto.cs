using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Application.DTO;

public class SetupPcDto
{
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }
    public PlacaMae PlacaMae { get; set; }
    public ICollection<Ram> Rams { get; set; }
    public ICollection<Ssd> Ssds { get; set; }
    public Fonte Fonte { get; set; }
    public Gabinete Gabinete { get; set; }
    public WaterCooler? WaterCooler { get; set; }
}
