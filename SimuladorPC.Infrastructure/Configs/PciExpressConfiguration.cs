using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Data.Configurations
{
    public class PciExpressSlotConfiguration : IEntityTypeConfiguration<PciExpressSlot>
    {
        public void Configure(EntityTypeBuilder<PciExpressSlot> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.Tamanho).IsRequired().HasMaxLength(10);
            builder.Property(p => p.VersaoPcie).IsRequired().HasMaxLength(10);
            builder.Property(p => p.SuportaSli).IsRequired();
        }
    }
}
