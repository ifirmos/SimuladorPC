namespace SimuladorPC.Application.DTO;

public class GabineteDto : ComponenteDto
{
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Comprimento { get; set; }
    public float PesoEmKg { get; set; }
    public int BaiasInternas { get; set; }
    public int BaiasExternas { get; set; }
    public string? CorIluminacao { get; set; }
    public bool TemJanela { get; set; }
    public string? CorGabinete { get; set; }
}
