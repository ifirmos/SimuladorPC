using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Enums;
using System.Net.Sockets;

namespace SimuladorPC.Data.Configurations
{
    public class WaterCoolerConfiguration : IEntityTypeConfiguration<WaterCooler>
    {
        public void Configure(EntityTypeBuilder<WaterCooler> builder)
        {
            builder.HasKey(wc => wc.Id);
            builder.Property(wc => wc.TamanhoRadiador_mm).IsRequired();
            builder.Property(wc => wc.QuantidadeFans).IsRequired();
            builder.Property(wc => wc.TdpMaximo).IsRequired();

            builder.Property(wc => wc.SocketsSuportados)
                   .IsRequired()
                   .HasColumnName("SocketsSuportados")
                   .HasColumnType("nvarchar(max)");
        }
    }
}
