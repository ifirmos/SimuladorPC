namespace SimuladorPC.Domain;

public class SlotM2
{
    public string Tamanho { get; set; } = string.Empty;
    public bool SuportaNvme { get; set; } // True se o slot suporta NVMe, false caso contrário
    public bool SuportaSata { get; set; }
    public string Versao {  get; set; } = string.Empty;
}
