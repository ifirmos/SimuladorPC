using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Data.Configurations;
public class ChipsetConfiguration : IEntityTypeConfiguration<Chipset>
{
    public void Configure(EntityTypeBuilder<Chipset> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Modelo).IsUnique();
    }
}


