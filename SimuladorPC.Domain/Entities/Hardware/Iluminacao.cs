namespace SimuladorPC.Domain.Entities.Hardware;

public class Iluminacao
{
    public int Id { get; set; }
    public string? TipoIluminacao { get; private set; }
    public string? CorFixa { get; private set; }
}