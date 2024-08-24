namespace SimuladorPC.Application.DTO
{
    public class ComponenteDto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Sku { get; set; }
        public int Preco { get; set; }

        public IList<string> Imagens { get; set; } = new List<string>();
        public string Miniatura {get; set; }
    }
}
