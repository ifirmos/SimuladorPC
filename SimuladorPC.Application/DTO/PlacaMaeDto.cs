using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class PlacaMaeDto : ComponenteDto
{
    public virtual SocketProcessadorDto SocketProcessador { get; set; }
    public int SocketProcessadorId { get; private set; }
    public virtual ChipsetDto Chipset { get; set; }
    public int ChipsetId { get; private set; }
    public virtual TamanhoPlacaMaeDto TamanhoPlacaMae { get; set; }
    public int TamanhoPlacaMaeId { get; private set; }
    public virtual TipoMemoriaDto TipoMemoria { get; set; }
    public int TipoMemoriaId { get; private set; }
    public int SlotsMemoria { get; set; }
    public int MaxMemoriaSuportadaGb { get; set; }
    public virtual ICollection<PciExpressSlotDto> PciExpressSlots { get; set; }
}
