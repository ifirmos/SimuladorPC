namespace SimuladorPC.Domain.Entities.Hardware;
public class PlacaMae : Componente
{
    public SocketProcessador SocketProcessador { get; private set; }
    public int SocketProcessadorId { get; private set; }
    public Chipset Chipset { get; private set; }
    public int ChipsetId { get; private set; }
    public TamanhoPlacaMae TamanhoPlacaMae { get; private set; }
    public int TamanhoPlacaMaeId { get; private set; }
    public TipoMemoria TipoMemoria { get; private set; }
    public int TipoMemoriaId { get; private set; }
    public int SlotsMemoria { get; private set; }
    public int MaxMemoriaSuportadaGb { get; private set; }
    
}
