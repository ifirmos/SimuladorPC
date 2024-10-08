namespace SimuladorPC.Application.DTO;

public class SoftwareDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Imagem { get; set; }
    public string Categoria { get; set; }
    public string Versao { get; set; }
    public int Peso { get; set; }
    public string Descricao { get; set; }
    public IEnumerable<RequisitosHardwareDto> Requisitos { get; set; }
}
        