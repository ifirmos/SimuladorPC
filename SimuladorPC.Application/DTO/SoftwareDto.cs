namespace SimuladorPC.Application.DTO;

public class SoftwareDto
{
    public string Nome { get; set; }
    public string Versao { get; set; }
    public string Descricao { get; set; }
    public IEnumerable<RequisitosHardwareDto> Requisitos { get; set; }
}
        