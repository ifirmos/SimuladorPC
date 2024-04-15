namespace SimuladorPC.Domain.Entities;

public class CPU : Componente
{
    public int Nucleos { get; set; }
    public float Frequencia { get; set; }
    public string Socket { get; set; }

}
