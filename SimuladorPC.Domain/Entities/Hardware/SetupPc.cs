namespace SimuladorPC.Domain.Entities.Hardware;

public class SetupPc
{
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }
    public PlacaMae PlacaMae { get; set; }
    public List<Ram> Rams { get; set; }
    public List<Ssd> Ssds { get; set; }
    public Fonte Fonte { get; set; }
    public Gabinete Gabinete { get; set; }
    public WaterCooler? WaterCooler { get; set; }

    public SetupPc()
    {
    }
}

