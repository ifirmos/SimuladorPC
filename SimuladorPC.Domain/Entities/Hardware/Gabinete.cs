namespace SimuladorPC.Domain.Entities.Hardware;

public class Gabinete : Componente
{
    public int Altura_Cm { get; private set; }
    public int Largura_Cm { get; private set; }
    public int Comprimento_Cm { get; private set; }
    public int SuporteRadiador_mm { get; private set; }
    public float Peso_Kg { get; private set; }
    public int BaiasInternas { get; private set; }
    public int BaiasExternas { get; private set; }
    public string CorIluminacao { get; private set; }
    public bool TemJanela { get; private set; }
    public string CorGabinete { get; private set; }
}
