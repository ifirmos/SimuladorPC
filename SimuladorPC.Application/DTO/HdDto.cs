namespace SimuladorPC.Application.DTO;

public class HdDto : ComponenteDto
{
    public int Capacidade { get; private set; }
    public int VelocidadeLeituraEmMbps { get; private set; }
    public int VelocidadeEscritaEmMbps { get; private set; }
}
    