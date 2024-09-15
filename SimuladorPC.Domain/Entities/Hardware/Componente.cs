namespace SimuladorPC.Domain.Entities.Hardware;

public class Componente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int FabricanteId { get; private set; } // Adiciona o campo FK para o Fabricante
    public virtual Fabricante Fabricante { get; private set; }  // Navegação
    public string Sku { get; private set; }

    public int Preco { get; private set; }
    public int ConsumoEmWatts { get; private set; }
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
