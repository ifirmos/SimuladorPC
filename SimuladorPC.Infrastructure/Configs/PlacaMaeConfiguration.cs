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
            builder.Property(p => p.TamanhoPlacaMaeId).IsRequired();
            builder.Property(p => p.TipoMemoriaId).IsRequired();builder.HasMany(p => p.PciExpressSlots)
                   .WithOne()
                   .HasForeignKey(s => s.PlacaMaeId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
