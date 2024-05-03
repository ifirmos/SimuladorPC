using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna os erros de validação
            }

            Cpu cpu;
            try
            {
                cpu = _mapper.Map<Cpu>(cpuDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Cpu cpuCriado;
            try
            {
                cpuCriado = _cpuService.Add(cpu);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o cpu: {ex.Message}");
            }

            if (cpuCriado == null)
            {
                return BadRequest("Não foi possível criar o cpu.");
            }

            CpuDto cpuRetornoDto;
            try
            {
                cpuRetornoDto = _mapper.Map<CpuDto>(cpuCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o cpu criado para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(GetById), new { id = cpuCriado.Id }, cpuRetornoDto);
        }

    }
}
