namespace SimuladorPC.Domain.Entities.Software;
public class Software
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Versao { get; set; }
    public string Descricao { get; set; }
    public List<RequisitosHardware>? Requisitos { get; set; }
}
