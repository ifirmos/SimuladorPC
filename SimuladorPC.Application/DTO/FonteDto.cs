namespace SimuladorPC.Application.DTO;

public class FonteDto : ComponenteDto
{
    public int Potencia { get; set; }
    public bool Modular { get; set; }
    public bool PFCAtivo { get; set; }
}
