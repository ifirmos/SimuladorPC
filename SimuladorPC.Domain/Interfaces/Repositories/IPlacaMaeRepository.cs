﻿using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Domain.Interfaces.Repositories;

public interface IPlacaMaeRepository : IBaseRepository<PlacaMae>
{
    IEnumerable<PlacaMae> BuscaPorChipset(int chipsetId);
    IEnumerable<Cpu> ListarCpusCompativeis(int placaMaeId);
}