﻿using System.Collections.Generic;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Interfaces.Repositories;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Domain.Services;

public class GpuService : ComponenteService<Gpu>, IGpuService
{
    private readonly IGpuRepository _gpuRepository;

    public GpuService(IGpuRepository gpuRepository) : base(gpuRepository)
    {
        _gpuRepository = gpuRepository;
    }

    public override IEnumerable<Gpu> GetAll()
    {
        return _gpuRepository.GetAll();
    }

    public override Gpu GetById(int id)
    {
        return _gpuRepository.GetById(id);
    }
}
