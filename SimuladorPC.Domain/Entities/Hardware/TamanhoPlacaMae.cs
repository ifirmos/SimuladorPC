namespace SimuladorPC.Domain.Entities.Hardware
{
    public class TamanhoPlacaMae(string tamanho)
    {
        public int Id { get; private set; }
        public string Tamanho { get; private set; } = tamanho;
    }
}