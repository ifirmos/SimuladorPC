using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Software;

public class SoftwareConfiguration : IEntityTypeConfiguration<Software>
{
    public void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Nome).IsRequired().HasMaxLength(200);

        builder.HasMany(s => s.Requisitos)
               .WithOne()
               .HasForeignKey(r => r.SoftwareId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}


