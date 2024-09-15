using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Application.DTO;

public class ChipsetDto
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public virtual Fabricante Fabricante { get; set; }
}
