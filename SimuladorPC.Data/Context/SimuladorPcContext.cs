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
        }
    }
}
