namespace SimuladorPC.Domain.Entities.Hardware;

public class Ssd : Componente
{
    public string Formato { get; private set; }
    public string Tipo { get; private set; }
    public string Geracao { get; private set; }
    public int CapacidadeGb { get; private set; }
    public int VelocidadeLeituraEmMbps { get; private set; }
    public int VelocidadeEscritaEmMbps { get; private set; }
}
