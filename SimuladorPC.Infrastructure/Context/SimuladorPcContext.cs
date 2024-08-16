using Microsoft.EntityFrameworkCore;
using SimuladorPC.Data.Configurations;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Infrastructure.Data;

public class SimuladorPcContext : DbContext
{
    public DbSet<Chipset> Chipsets { get; set; }
    public DbSet<Cpu> Cpus { get; set; }
    public DbSet<Gabinete> Gabinetes { get; set; }
    public DbSet<Fonte> Fontes { get; set; }
    public DbSet<Gpu> Gpus { get; set; }
    public DbSet<PlacaMae> PlacasMae { get; set; }
    public DbSet<Ram> Rams { get; set; }
    public DbSet<Hd> Hds { get; set; }
    public DbSet<Iluminacao> TiposIluminacao { get; set; }
    public DbSet<Ssd> Ssds { get; set; }
    public DbSet<WaterCooler> WaterCoolers { get; set; }
    public DbSet<Software> Softwares { get; set; }
    public DbSet<RequisitosHardware> RequisitosHardware { get; set;}

    public SimuladorPcContext(DbContextOptions<SimuladorPcContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new SoftwareConfiguration());
        modelBuilder.ApplyConfiguration(new RequisitosHardwareConfiguration());
        modelBuilder.ApplyConfiguration(new PlacaMaeConfiguration());
        modelBuilder.ApplyConfiguration(new ChipsetConfiguration());
        modelBuilder.ApplyConfiguration(new WaterCoolerConfiguration());

    }
}
