using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;

namespace SimuladorPC.Infrastructure.Data;

public class RequisitosHardwareRepository(SimuladorPcContext context) : BaseRepository<RequisitosHardware>(context), IRequisitosHardwareRepository
{
}
