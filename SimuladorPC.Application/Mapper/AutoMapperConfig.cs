using AutoMapper;
using SimuladorPC.Application.DTO;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;

public class AutoMappingConfig : Profile
{
    public AutoMappingConfig()
    {
        CreateMap<Componente, ComponenteDto>().IncludeAllDerived();
        CreateMap<SetupPc, SetupPcDto>().IncludeAllDerived();
        CreateMap<Gabinete, GabineteDto>().ReverseMap();
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<SocketProcessador, SocketProcessadorDto>().ReverseMap();
        CreateMap<TipoMemoria, TipoMemoriaDto>().ReverseMap();
        CreateMap<Ram, RamDto>().ReverseMap();
        CreateMap<Fonte, FonteDto>().ReverseMap();
        CreateMap<Cpu, CpuDto>().ReverseMap()
            .ForMember(dest => dest.Socket, opt => opt.MapFrom(src => src.Socket));
        CreateMap<Chipset, ChipsetDto>().ReverseMap();
        CreateMap<TamanhoPlacaMae, TamanhoPlacaMaeDto>().ReverseMap();

        CreateMap<Ssd, SsdDto>().ReverseMap();


        CreateMap<PlacaMae, PlacaMaeDto>()
             .ForMember(dest => dest.SocketProcessador, opt => opt.MapFrom(src => src.SocketProcessador))
             .ForMember(dest => dest.Chipset, opt => opt.MapFrom(src => src.Chipset))
             .ForMember(dest => dest.TipoMemoria, opt => opt.MapFrom(src => src.TipoMemoria))
             .ForMember(dest => dest.TamanhoPlacaMae, opt => opt.MapFrom(src => src.TamanhoPlacaMae))
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