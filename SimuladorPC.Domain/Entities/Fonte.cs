namespace SimuladorPC.Domain.Entities;

public class Fonte : Componente
{
    public int Potencia { get; set; }
    public string Formato { get; set; }
    public bool Modular { get; set; }
    public bool PFCAtivo { get; set; }
}
