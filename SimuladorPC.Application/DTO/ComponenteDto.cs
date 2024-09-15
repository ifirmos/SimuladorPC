namespace SimuladorPC.Application.DTO
{
    public class ComponenteDto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public FabricanteDto Fabricante { get; set; }
        public string Sku { get; set; }
        public int Preco { get; set; }
        public int ConsumoEmWatts { get; set; }

        public IList<string> Imagens { get; set; } = new List<string>();
        public string Miniatura {get; set; }
    }
}
