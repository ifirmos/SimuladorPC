using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities;

public class Gabinete : Componente
{
    public string Tipo { get; set; } // Ex: "Full Tower", "Mid Tower", "Mini Tower"
    public double Altura { get; set; } // Altura do gabinete em milímetros
    public double Largura { get; set; } // Largura do gabinete em milímetros
    public double Comprimento { get; set; } // Comprimento do gabinete em milímetros
    public int BaiasInternas { get; set; } // Número de baias internas para HDDs/SSDs
    public int BaiasExternas { get; set; } // Número de baias externas (pode ser 0 para designs modernos)
    public List<TamanhoPlacaMae> SuportePlacaMae { get; set; } 
    public Iluminacao Iluminacao { get; set; }
    public bool TemJanela { get; set; } // True se o gabinete tem uma janela lateral
    public bool TemFiltrosDePoeira { get; set; } // True se o gabinete possui filtros de poeira
    public string Cor { get; set; } // Cor predominante do gabinete
    // Adicione outras propriedades que considere importantes para a seleção de um gabinete
}
