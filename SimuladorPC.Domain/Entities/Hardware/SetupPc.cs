namespace SimuladorPC.Domain.Entities.Hardware
{
    public class SetupPc
    {
        public virtual Cpu Cpu { get; set; }
        public virtual Gpu Gpu { get; set; }
        public virtual PlacaMae PlacaMae { get; set; }
        public virtual ICollection<Ram> Rams { get; set; }
        public virtual ICollection<Ssd> Ssds { get; set; }
        public virtual Fonte Fonte { get; set; }
        public virtual Gabinete Gabinete { get; set; }
        public virtual WaterCooler? WaterCooler { get; set; }

        public SetupPc()
        {
            Rams = new List<Ram>();
            Ssds = new List<Ssd>();
        }

        public void AdicionarCpu(Cpu cpu)
        {
            Cpu = cpu;
        }

        public void AdicionarGpu(Gpu gpu)
        {
            Gpu = gpu;
        }

        public void AdicionarPlacaMae(PlacaMae placaMae)
        {
            PlacaMae = placaMae;
        }

        public void AdicionarRam(Ram ram)
        {
            Rams.Add(ram);
        }

        public void AdicionarSsd(Ssd ssd)
        {
            Ssds.Add(ssd);
        }

        public void AdicionarFonte(Fonte fonte)
        {
            Fonte = fonte;
        }

        public void AdicionarGabinete(Gabinete gabinete)
        {
            Gabinete = gabinete;
        }

        public void AdicionarWaterCooler(WaterCooler waterCooler)
        {
            WaterCooler = waterCooler;
        }
    }
}
