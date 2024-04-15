namespace SimuladorPC.Domain.Entities;

public class Iluminacao
{
    public bool TemIluminacao { get; set; } // True se o componente tem iluminação
    public bool IsRgb { get; set; } // True se a iluminação é RGB
    public bool IsArgb { get; set; } // True se a iluminação é ARGB (Addressable RGB)
    public string CorFixa { get; set; } // Cor fixa, se aplicável (ex: "Vermelho", "Azul")
    // Adicione outras propriedades relacionadas à iluminação conforme necessário
}
