using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Application.DTO;

public class SsdDto : ComponenteDto
{
    public string Formato { get; set; }
    public string Tipo { get; set; }
    public string Geracao { get; set; }
    public int CapacidadeGb { get; set; }
    public int VelocidadeLeituraEmMbps { get; set; }
    public int VelocidadeEscritaEmMbps { get; set; }
}
