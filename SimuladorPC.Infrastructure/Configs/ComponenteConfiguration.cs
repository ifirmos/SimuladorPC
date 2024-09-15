using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Data.Configurations
{
    public class ComponenteConfiguration : IEntityTypeConfiguration<Componente>
    {
        public void Configure(EntityTypeBuilder<Componente> builder)
        {
           
        }
    }
}
