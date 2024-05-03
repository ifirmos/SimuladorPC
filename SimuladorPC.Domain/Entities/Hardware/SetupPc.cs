namespace SimuladorPC.Domain.Entities.Hardware;

public class SetupPc
{
    public Cpu Cpu { get;private set; }
    public Gpu Gpu { get;private set; }
    public PlacaMae PlacaMae { get;private set; }
    public List<Ram> Rams { get;private set; } = [];
    public List<Ssd> Ssds { get;private set; } = [];
    public Fonte Fonte { get;private set; }
    public Gabinete Gabinete { get;private set; }
    public WaterCooler? WaterCooler { get;private set; }

    public SetupPc()
    {
    }
}

