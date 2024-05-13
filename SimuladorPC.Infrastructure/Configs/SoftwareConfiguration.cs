using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Data.Configurations;
public class SoftwareConfiguration : IEntityTypeConfiguration<Software>
{
    public void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Nome).IsRequired().HasMaxLength(200);
        builder.Property(s => s.Versao).IsRequired().HasMaxLength(50);
        builder.Property(s => s.Descricao).IsRequired(false).HasMaxLength(500);

        // Configuração da relação com RequisitosHardware
        builder.HasMany(s => s.Requisitos)
               .WithOne()
               .HasForeignKey(r => r.SoftwareId)
               .OnDelete(DeleteBehavior.Cascade); 
    }
}


