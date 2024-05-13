using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Data.Configurations;
public class RequisitosHardwareConfiguration : IEntityTypeConfiguration<RequisitosHardware>
{
    public void Configure(EntityTypeBuilder<RequisitosHardware> builder)
    {
        builder.HasKey(r => r.Id);

        // Campos obrigatórios
        builder.Property(r => r.SoftwareId).IsRequired();

        // Configuração da relação
        builder.HasOne(r => r.Software)
               .WithMany(s => s.Requisitos)
               .HasForeignKey(r => r.SoftwareId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}


