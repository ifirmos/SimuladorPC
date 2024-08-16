using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Data.Configurations
{
    public class PlacaMaeConfiguration : IEntityTypeConfiguration<PlacaMae>
    {
        public void Configure(EntityTypeBuilder<PlacaMae> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SocketProcessador).IsRequired();
            builder.Property(p => p.ChipsetId).IsRequired();
        }
    }
}
