using SimuladorPC.Domain.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladorPC.Application.DTO;

public class SetupPcDto
{
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }
    public PlacaMae PlacaMae { get; set; }
    public List<Ram> Rams { get; set; }
    public List<Ssd> Ssds { get; set; }
    public Fonte Fonte { get; set; }
    public Gabinete Gabinete { get; set; }
    public WaterCooler? WaterCooler { get; set; }
}
