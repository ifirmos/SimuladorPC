using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class PciExpressSlotDto
{
    public int Id { get; private set; }
    public int Quantidade { get; set; }
    public string Tamanho { get; set; } // Ex: x1, x4, x8, x16
    public VersaoPcie VersaoPcie { get; set; } // Ex: 2.0, 3.0, 4.0
    public bool SuportaSli { get; set; } // Suporte para SLI/Crossfire
}
