using SimuladorPC.Domain.Enums;

namespace SimuladorPC.Domain.Entities.Hardware;

public class WaterCooler : Componente
{
    public int TamanhoRadiador_mm { get; private set; }
    public int QuantidadeFans { get; private set; }
    public int TdpMaximo { get; private set; } 
    public virtual IList<SocketProcessador> SocketsSuportados { get; private set; }
    public void AddSocketProcessador(SocketProcessador SocketProcessador)
    {
        SocketsSuportados.Add(SocketProcessador);
    }
}
