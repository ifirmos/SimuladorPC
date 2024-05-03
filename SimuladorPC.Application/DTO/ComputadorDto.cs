namespace SimuladorPC.Application.DTO;

public class ComputadorDto : SetupPcDto
{
    public int ComputadorId { get; private set; }
    public string Sku { get; set; }
    public string Descricao { get; set; }
}
