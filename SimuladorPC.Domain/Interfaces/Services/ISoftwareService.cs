﻿using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Domain.Interfaces.Services;

public interface ISoftwareService
{
    IEnumerable<Software> GetAll();
    Software GetById(int id);
    Software Add(Software entity);
    void Update(Software entity);
    void Delete(Software entity);
}

