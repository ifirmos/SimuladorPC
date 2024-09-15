using AutoMapper;
using SimuladorPC.Application.DTO;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;

public class AutoMappingConfig : Profile
{
    public AutoMappingConfig()
    {
        CreateMap<Componente, ComponenteDto>().ReverseMap();
        CreateMap<Fabricante, FabricanteDto>().ReverseMap();
        CreateMap<SetupPc, SetupPcDto>().IncludeAllDerived();
        CreateMap<Gabinete, GabineteDto>().ReverseMap();
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<Ram, RamDto>().ReverseMap();
        CreateMap<Fonte, FonteDto>().ReverseMap();
        CreateMap<Cpu, CpuDto>().ReverseMap();
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<Ssd, SsdDto>().ReverseMap();
        CreateMap<PciExpressSlot, PciExpressSlotDto>().ReverseMap();
        CreateMap<WaterCooler, WaterCoolerDto>()
            .ForMember(dest => dest.SocketsSuportados, opt => opt.MapFrom(src => src.SocketsSuportados.Select(s => s.ToString()).ToList()))
            .ReverseMap();


        CreateMap<PlacaMae, PlacaMaeDto>()            
             .ForMember(dest => dest.PciExpressSlots, opt => opt.MapFrom(src => src.PciExpressSlots))
             .ReverseMap();

        CreateMap<Software, SoftwareDto>()
            .ForMember(dest => dest.Requisitos, opt => opt.MapFrom(src => src.Requisitos))
            .ReverseMap();

        CreateMap<RequisitosHardware, RequisitosHardwareDto>()
             .ForMember(dest => dest.TecnologiasRequeridas,
                 opt => opt.MapFrom(src => src.TecnologiasRequeridas.Select(t => t.ToString()).ToList()))
             .ForMember(dest => dest.NivelDesempenho,
                       opt => opt.MapFrom(src => src.NivelDesempenho.ToString()))
             .ReverseMap();

        CreateMap<Gpu, GpuDto>()
             .ForMember(dest => dest.TecnologiasSuportadas,
                 opt => opt.MapFrom(src => src.TecnologiasSuportadas.Select(t => t.ToString()).ToList())).ReverseMap();
    }
}