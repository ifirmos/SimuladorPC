using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Application.DTO;
using AutoMapper;

namespace SimuladorPC.Api.Controllers
{
    [ApiController]
    [Route("api/builder")]
    public class PcBuilderController : ControllerBase
    {
        private readonly IPcBuilderService _pcBuilderService;
        private readonly ISoftwareService _softwareService;
        private readonly IMapper _mapper;

        public PcBuilderController(IPcBuilderService pcBuilderService, ISoftwareService softwareService, IMapper mapper)
        {
            _pcBuilderService = pcBuilderService;
            _softwareService = softwareService;
            _mapper = mapper;
        }

        [HttpGet("build/{softwareId}")]
        public async Task<IActionResult> BuildPc(int softwareId)
        {
            try
            {
                var software = _softwareService.ObterPorId(softwareId);
                if (software == null)
                {
                    return NotFound("Não foi possível localizar um software com este ID.");
                }

                var setupPc = _pcBuilderService.AutoBuildPcConfiguration(software);
                if (setupPc == null)
                {
                    return NotFound("Não foi possível construir a configuração com os dados fornecidos.");
                }

                return Ok(setupPc);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro ao construir a configuração do PC: {ex.Message}");
            }
        }

        [HttpPost("build")]
        public async Task<IActionResult> BuildPc([FromBody] RequisitosHardwareDto requisitoDto)
        {
            try
            {
                if (requisitoDto == null)
                {
                    return BadRequest("Requisito de hardware não fornecidos.");
                }

                var requisito = _mapper.Map<RequisitosHardware>(requisitoDto);
                var setupPc = _pcBuilderService.AutoBuildPcConfiguration(requisito);
                if (setupPc == null)
                {
                    return NotFound("Não foi possível construir a configuração com os dados fornecidos.");
                }

                return Ok(setupPc);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro ao construir a configuração do PC: {ex.Message}");
            }
        }
    }
}
