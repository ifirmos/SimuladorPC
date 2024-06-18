using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Application.DTO;
using AutoMapper;

namespace SimuladorPC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpPost("build")]
        public async Task<IActionResult> BuildPc(string softwareNome)
        {
            try
            {
                var software = _softwareService.ObterSoftwarePorNome(softwareNome);
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
    }
}
