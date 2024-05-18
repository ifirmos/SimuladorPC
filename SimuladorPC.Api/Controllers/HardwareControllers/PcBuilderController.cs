using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Enums;
using SimuladorPC.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace SimuladorPC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PcBuilderController : ControllerBase
    {
        private readonly IPcBuilderService _pcBuilderService;

        public PcBuilderController(IPcBuilderService pcBuilderService)
        {
            _pcBuilderService = pcBuilderService;
        }

        [HttpPost("build")]
        public async Task<IActionResult> BuildPc([FromBody] BuildPcRequest request)
        {
            try
            {
                var setupPc = _pcBuilderService.AutoBuildPcConfiguration(request.Software);

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

    public class BuildPcRequest
    {
        public Software Software { get; set; }
        public NivelDesempenho DesempenhoNivel { get; set; }
    }
}
