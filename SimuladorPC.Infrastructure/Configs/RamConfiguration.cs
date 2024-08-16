using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Data.Configurations
{
    public class RamConfiguration : IEntityTypeConfiguration<Ram>
    {
        public void Configure(EntityTypeBuilder<Ram> builder)
        {
            // Definir chave primária
            builder.HasKey(r => r.Id);
        }
    }
}
