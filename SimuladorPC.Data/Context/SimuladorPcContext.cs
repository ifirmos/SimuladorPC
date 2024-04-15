using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities;

namespace SimuladorPC.Data
{
    public class SimuladorPcContext : DbContext
    {
        public SimuladorPcContext(DbContextOptions<SimuladorPcContext> options)
            : base(options)
        {
        }
        
        public DbSet<Gabinete> Gabinetes { get; set; }
        public DbSet<WaterCooler> WaterCoolers { get; set; }
        // Adicione DbSets para outras entidades conforme necessário

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WaterCooler>().OwnsOne(wc => wc.Iluminacao);
            modelBuilder.Entity<Gabinete>().OwnsOne(g => g.Iluminacao);
        }
    }
}
