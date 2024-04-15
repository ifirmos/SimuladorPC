namespace SimuladorPC.Domain.Entities;

public class PlacaMae : Componente
{
    public string Socket { get; set; } = string.Empty;
    public string Chipset { get; set; } = string.Empty;
    public string Formato { get; set; } = string.Empty;
    public int SlotsMemoria { get; set; }
    public string TipoMemoriaSuportada { get; set; } = string.Empty;
    public int MaxMemoriaSuportada { get; set; }
    public List<PcieSlot> SlotsPcie { get; set; } = [];
    public List<PortaUsb> PortasUsb { get; set; } = [];
    public List<SlotM2> SlotsM2 { get; set; } = [];
    public bool SuporteM2 { get; set; }
}
