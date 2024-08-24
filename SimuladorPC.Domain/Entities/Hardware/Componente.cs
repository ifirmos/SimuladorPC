namespace SimuladorPC.Domain.Entities.Hardware;

public class Componente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Fabricante { get; private set; }
    public string Sku { get; private set; }

    public int Preco { get; private set; }
    public IList<string> Imagens { get; private set; } = [];
    public string Miniatura { get; private set; }

    public void AdicionarImagem(string url)
    {
        Imagens.Add(url.ToLower()); 
    }

    public IEnumerable<string> ObterImagens()
    {
        return Imagens;
    }

    public string ObterMiniatura()
    {
        return Miniatura;
    }
}
