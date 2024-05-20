namespace SimuladorPC.Domain.Entities.Hardware;

public class SetupPc
{
    public virtual Cpu Cpu { get; set; }
    public virtual Gpu Gpu { get; set; }
    public virtual PlacaMae PlacaMae { get; set; }
    public virtual IEnumerable<Ram> Rams { get; set; }
    public virtual IEnumerable<Ssd> Ssds { get; set; }
    public virtual Fonte Fonte { get; set; }
    public virtual Gabinete Gabinete { get; set; }
    public virtual WaterCooler? WaterCooler { get; set; }

    public SetupPc()
    {
    }
}

