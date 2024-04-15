namespace SimuladorPC.Domain.Entities;

public class SSD : Componente
{
    public int Capacidade { get; set; }
    public string Tipo { get; set; }
    public int VelocidadeLeitura { get; set; }
    public int VelocidadeEscrita { get; set; }
}
