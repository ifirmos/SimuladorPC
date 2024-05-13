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
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<SocketProcessador, SocketProcessadorDto>().ReverseMap();
        CreateMap<TamanhoPlacaMae, TamanhoPlacaMaeDto>().ReverseMap();
        CreateMap<TipoMemoria, TipoMemoriaDto>().ReverseMap();
        CreateMap<PlacaMae, PlacaMaeDto>()
            .ForMember(dest => dest.SocketProcessador, opt => opt.MapFrom(src => src.SocketProcessador))
            .ForMember(dest => dest.Chipset, opt => opt.MapFrom(src => src.Chipset))
            .ForMember(dest => dest.TamanhoPlacaMae, opt => opt.MapFrom(src => src.TamanhoPlacaMae))
            .ForMember(dest => dest.TipoMemoria, opt => opt.MapFrom(src => src.TipoMemoria))
            .ReverseMap();
        CreateMap<Ram, RamDto>().ReverseMap();
        CreateMap<Fonte, FonteDto>().ReverseMap();
        CreateMap<Gpu, GpuDto>().ReverseMap();
        CreateMap<Cpu, CpuDto>().ReverseMap();
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<Ssd, SsdDto>().ReverseMap();
        CreateMap<Software, SoftwareDto>()
            .ForMember(dest => dest.Requisitos, opt => opt.MapFrom(src => src.Requisitos))
            .ReverseMap();

        CreateMap<RequisitosHardware, RequisitosHardwareDto>().ReverseMap();
    }
}