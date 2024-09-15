namespace SimuladorPC.Domain.Entities.Hardware;

public class Chipset
{
    public int Id { get; private set; }
    public string Modelo { get; private set; }
    public virtual Fabricante Fabricante { get; private set; }
}
