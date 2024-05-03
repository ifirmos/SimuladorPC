namespace SimuladorPC.Application.DTO;

public class HdDto : ComponenteDto
{
    public int Capacidade { get; private set; }
    public int VelocidadeLeitura { get; private set; }
    public int VelocidadeEscrita { get; private set; }
}
    