using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Hardware
{
    public class PciExpressSlot
    {
        public int Id { get; private set; }
        public int Quantidade { get; private set; }
        public string Tamanho { get; private set; } // Ex: x1, x4, x8, x16
        public VersaoPcie VersaoPcie { get; private set; } // Ex: 2.0, 3.0, 4.0
        public bool SuportaSli { get; private set; } // Suporte para SLI/Crossfire

        // Propriedade de navegação
        public int PlacaMaeId { get; private set; }
    }
}
