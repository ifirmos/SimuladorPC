using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class PlacaMaeDto : ComponenteDto
{
    public virtual SocketProcessador SocketProcessador { get; set; }
    public virtual ChipsetDto Chipset { get; set; }
    public int ChipsetId { get; private set; }
    public  TamanhoPlacaMae TamanhoPlacaMae { get; set; }
    public  virtual TipoMemoria TipoMemoria { get; set; }
    public int SlotsMemoria { get; set; }
    public int MaxMemoriaSuportadaGb { get; set; }
    public virtual ICollection<PciExpressSlotDto> PciExpressSlots { get; set; }
}
