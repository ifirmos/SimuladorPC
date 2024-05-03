using Microsoft.EntityFrameworkCore;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Interfaces.Repositories;

namespace SimuladorPC.Infrastructure.Data;

public class SoftwareRepository(SimuladorPcContext context) : BaseRepository<Software>(context), ISoftwareRepository
{
}
