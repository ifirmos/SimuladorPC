﻿using SimuladorPC.Domain.Entities.Software;
namespace SimuladorPC.Domain.Interfaces.Services;

public interface IRequisitosHardwareService
{
    IEnumerable<RequisitosHardware> GetAll();
    RequisitosHardware GetById(int id);
    RequisitosHardware Add(RequisitosHardware entity);
    void Update(RequisitosHardware entity);
    void Delete(RequisitosHardware entity);
}

