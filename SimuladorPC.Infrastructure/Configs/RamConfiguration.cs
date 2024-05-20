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

            // Mapear propriedades
            builder.Property(r => r.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.Fabricante)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.Modelo)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.CapacidadeGb)
                   .IsRequired();

            builder.Property(r => r.ClockBaseMhz)
                   .IsRequired();

            builder.Property(r => r.ClockMaximoOverclockMhz)
                   .IsRequired();

            builder.Property(r => r.Rgb)
                   .IsRequired();

            builder.Property(r => r.Latencia)
                   .IsRequired();

            builder.Property(r => r.Voltagem)
                   .IsRequired();

            builder.Property(r => r.Ecc)
                   .IsRequired();

            builder.Property(r => r.XmpSuportado)
                   .IsRequired();

            builder.Property(r => r.Modulos)
                   .IsRequired();

            // Configurar relacionamento com TipoMemoria
            builder.HasOne(r => r.TipoMemoria)
                   .WithMany()
                   .HasForeignKey("TipoMemoriaId")
                   .OnDelete(DeleteBehavior.Restrict);

            // Definir nome da tabela (opcional)
            builder.ToTable("Rams");
        }
    }
}
