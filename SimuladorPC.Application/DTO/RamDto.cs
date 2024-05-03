namespace SimuladorPC.Application.DTO;

public class RamDto : ComponenteDto
{
    public int CapacidadeGb { get; set; }
    public int Clock { get; set; }
    public bool Rgb { get; set; }
}
