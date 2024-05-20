using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;
using AutoMapper;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/Cpu")]
    public class CpuController : ControllerBase
    {
        private readonly ICpuService _cpuService;
        private readonly IMapper _mapper;

        public CpuController(ICpuService cpuService, IMapper mapper)
        {
            _cpuService = cpuService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CpuDto>> GetAll()
        {
            var listaCpu = _cpuService.GetAll();
            var listaCpuDto = _mapper.Map<IEnumerable<CpuDto>>(listaCpu);
            return Ok(listaCpuDto);
        }

        [HttpGet("{id}")]
        public ActionResult<CpuDto> GetById(int id)
        {
            var cpu = _cpuService.GetById(id);
            if (cpu == null)
            {
                return NotFound();
            }
            var cpuDto = _mapper.Map<CpuDto>(cpu);
            return Ok(cpuDto);
        }

        [HttpPost]
        public ActionResult<CpuDto> Criar(CpuDto cpuDto)
        {
            var cpu = _mapper.Map<Cpu>(cpuDto);
            _cpuService.Add(cpu);
            var cpuDtoCriado = _mapper.Map<CpuDto>(cpu);
            return Ok(cpuDtoCriado);
        }

    }
}
