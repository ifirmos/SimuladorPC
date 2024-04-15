using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities;

public class WaterCooler : Componente
{
    public string TamanhoRadiador { get; set; }
    public int QuantidadeFans { get; set; }
    public Iluminacao? Iluminacao { get; set; }
    public List<SocketSuportado> SocketsCompativeis { get; set; } = [];
}
