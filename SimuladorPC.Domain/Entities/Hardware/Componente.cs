namespace SimuladorPC.Domain.Entities.Hardware;

public class Componente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Fabricante { get; private set; }
    public string Modelo { get; private set; }
    public int Preco { get; private set; }
}
