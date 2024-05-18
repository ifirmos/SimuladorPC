using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Application.DTO;

public class PlacaMaeDto : ComponenteDto
{
    public SocketProcessadorDto SocketProcessador { get; set; }
    public int SocketProcessadorId { get; private set; }
    public ChipsetDto Chipset { get;  set; }
    public int ChipsetId { get; private set; }
    public TamanhoPlacaMaeDto TamanhoPlacaMae { get;  set; }
    public int TamanhoPlacaMaeId { get; private set; }
    public TipoMemoriaDto TipoMemoria { get;  set; }
    public int TipoMemoriaId { get; private set; }
    public int SlotsMemoria { get;  set; }
    public int MaxMemoriaSuportadaGb { get; private set; }
}
