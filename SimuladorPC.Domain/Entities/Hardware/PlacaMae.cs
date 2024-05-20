
namespace SimuladorPC.Domain.Entities.Hardware;
public class PlacaMae : Componente
{
    public virtual SocketProcessador SocketProcessador { get; private set; }
    public int SocketProcessadorId { get; private set; }
    public virtual Chipset Chipset { get; private set; }
    public int ChipsetId { get; private set; }
    public virtual TamanhoPlacaMae TamanhoPlacaMae { get; private set; }
    public int TamanhoPlacaMaeId { get; private set; }
    public virtual TipoMemoria TipoMemoria { get; private set; }
    public int TipoMemoriaId { get; private set; }
    public int SlotsMemoria { get; private set; }
    public int MaxMemoriaSuportadaGb { get; private set; }
    
    public void SetChipset(Chipset chipset)
    {
        Chipset = chipset;
        ChipsetId = chipset.Id;
    }
    public void SetSocket(SocketProcessador socket)
    {
        SocketProcessador = socket;
        SocketProcessadorId = socket.Id;
    }

    public void SetTamanhoPlacaMae(TamanhoPlacaMae tamanhoPlacaMae)
    {
        TamanhoPlacaMae = tamanhoPlacaMae;
        TamanhoPlacaMaeId = tamanhoPlacaMae.Id;
    }

    public void SetTipoMemoria(TipoMemoria tipoMemoria)
    {
        TipoMemoria = tipoMemoria;
        TipoMemoriaId = tipoMemoria.Id;
    }
}
