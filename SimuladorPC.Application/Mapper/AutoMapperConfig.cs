using AutoMapper;
using SimuladorPC.Application.DTO;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;

public class AutoMappingConfig : Profile
{
    public AutoMappingConfig()
    {
        CreateMap<Componente, ComponenteDto>().IncludeAllDerived();
        CreateMap<SetupPc, SetupPcDto>().IncludeAllDerived();
        CreateMap<Gabinete, GabineteDto>().ReverseMap();
        CreateMap<PlacaMae, PlacaMaeDto>().ReverseMap();
        CreateMap<Ram, RamDto>().ReverseMap();
        CreateMap<Fonte, FonteDto>().ReverseMap();
        CreateMap<Gpu, GpuDto>().ReverseMap();
        CreateMap<Cpu, CpuDto>().ReverseMap();
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<Ssd, SsdDto>().ReverseMap();
        CreateMap<Software, SoftwareDto>().ReverseMap();
        CreateMap<RequisitosHardware, RequisitosHardwareDto>().ReverseMap();

    }
}