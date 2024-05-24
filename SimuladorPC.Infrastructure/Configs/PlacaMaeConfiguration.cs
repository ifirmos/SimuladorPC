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
            builder.Property(p => p.SocketProcessadorId).IsRequired();
            builder.Property(p => p.ChipsetId).IsRequired();
            builder.Property(p => p.TamanhoPlacaMaeId).IsRequired();
            builder.Property(p => p.TipoMemoriaId).IsRequired();

            builder.HasOne(p => p.SocketProcessador).WithMany().HasForeignKey(p => p.SocketProcessadorId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Chipset).WithMany().HasForeignKey(p => p.ChipsetId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.TamanhoPlacaMae).WithMany().HasForeignKey(p => p.TamanhoPlacaMaeId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.TipoMemoria).WithMany().HasForeignKey(p => p.TipoMemoriaId).IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.PciExpressSlots)
                   .WithOne()
                   .HasForeignKey(s => s.PlacaMaeId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
