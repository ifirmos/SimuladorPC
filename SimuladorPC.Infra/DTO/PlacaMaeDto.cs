using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Application.DTO;

public class PlacaMaeDto : ComponenteDto
{
    public SocketProcessador SocketProcessador { get; set; }
    public int SocketProcessadorId { get; private set; }
    public Chipset Chipset { get; set; }
    public int ChipsetId { get; private set; }
    public TamanhoPlacaMae TamanhoPlacaMae { get; set; }
    public int TamanhoPlacaMaeId { get; private set; }
    public TipoMemoria TipoMemoria { get; set; }
    public int TipoMemoriaId { get; private set; }
    public int SlotsMemoria { get; set; }
    public int MaxMemoriaSuportadaGb { get; set; }
}
