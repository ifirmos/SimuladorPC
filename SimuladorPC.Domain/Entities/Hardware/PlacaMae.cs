
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Hardware;
public class PlacaMae : Componente
{
    public SocketProcessador SocketProcessador { get; private set; }
    public int ChipsetId { get; private set; }
    public int TamanhoPlacaMaeId { get; private set; }
    public int TipoMemoriaId { get; private set; }
    public int SlotsMemoria { get; private set; }
    public int MaxMemoriaSuportadaGb { get; private set; }
    public virtual ICollection<PciExpressSlot> PciExpressSlots { get; private set; }
    public VersaoPcie VersaoPcie { get; private set; }

    public void SetChipset(int  chipsetId)
    {
        ChipsetId = chipsetId;
    }
    public void SetSocket(SocketProcessador socketProcessador)
    {
        SocketProcessador = socketProcessador;
    }

    public void SetTamanhoPlacaMae(int tamanhoPlacaMaeId)
    {
        TamanhoPlacaMaeId = tamanhoPlacaMaeId;
    }

    public void SetTipoMemoria(int tipoMemoriaId)
    {
        TipoMemoriaId = tipoMemoriaId;
    }
    public void AdicionarPciExpressSlot(PciExpressSlot pciExpressSlot)
    {
        PciExpressSlots.Add(pciExpressSlot);
    }
}
