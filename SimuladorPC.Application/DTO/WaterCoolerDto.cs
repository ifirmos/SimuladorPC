using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Application.DTO;

public class WaterCoolerDto : ComponenteDto
{
    public int TamanhoRadiador_mm { get; set; }
    public int QuantidadeFans { get; set; }
    public int TdpMaximo { get; set; }
    public virtual IList<SocketProcessador> SocketsSuportados { get; private set; }
}
