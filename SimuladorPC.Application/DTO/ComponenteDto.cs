namespace SimuladorPC.Application.DTO;

public class ComponenteDto
{
    public int Id { get; private set; }
    public string Nome { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Preco { get; set; }
    protected ComponenteDto(int id = 0, string nome = "", string fabricante = "", string modelo = "")
    {
        Id = id;
        Nome = nome;    
        Fabricante = fabricante;
        Modelo = modelo;
    }
}
