using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Application.DTO;

public class SoftwareDto
{
    public int Id { get; private set; }
    public string Nome { get; set; }
    public string Versao { get; set; }
    public string Descricao { get; set; }
    public List<RequisitosHardware>? Requisitos { get; private set; }
}
        