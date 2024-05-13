namespace SimuladorPC.Domain.Entities.Software;
public class Software
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Versao { get; private set; }
    public string Descricao { get; private set; }
    public IEnumerable<RequisitosHardware> Requisitos { get; set; }
}
