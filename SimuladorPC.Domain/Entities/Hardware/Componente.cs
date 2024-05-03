namespace SimuladorPC.Domain.Entities.Hardware;

public class Componente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Fabricante { get; private set; }
    public string Modelo { get; private set; }
    protected Componente(int id = 0, string nome = "", string fabricante = "", string modelo = "")
    {
        Id = id;
        Nome = nome;
        Fabricante = fabricante;
        Modelo = modelo;
    }
}
