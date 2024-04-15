namespace SimuladorPC.Domain.Entities;

public class GPU : Componente
{
    public int Memoria { get; set; }
    public string Chipset { get; set; }
    public int DisplayPort { get; set; }
    public int Hdmi { get; set; }
    public int Coolers { get; set; }
    public float FrequenciaBase { get; set; }
    public float FrequenciaMax { get; set; }
}
