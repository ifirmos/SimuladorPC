namespace SimuladorPC.Application.DTO;

public class GabineteDto : ComponenteDto
{
    public int Altura_Cm { get; set; }
    public int Largura_Cm { get; set; }
    public int SuporteRadiador_mm { get; set; }
    public int Comprimento_Cm { get; set; }
    public float Peso_Kg { get; set; }
    public int BaiasInternas { get; set; }
    public int BaiasExternas { get; set; }
    public string CorIluminacao { get; set; }
    public bool TemJanela { get; set; }
    public string CorGabinete { get; set; }
}
