namespace SimuladorPC.Domain.Entities.Hardware;

public class Computador : SetupPc
{
    public int id { get; private set; }
    public string Sku { get; private set; }
    public string Descricao { get; private set; }

    public Computador(string sku, string descricao)
    {
        Sku = sku;
        Descricao = descricao;
    }
}

