using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Software;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Domain.Services;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/Software")]
    public class SoftwareController : ControllerBase
    {
        private readonly ISoftwareService _SoftwareService;
        private readonly IMapper _mapper;

        public SoftwareController(ISoftwareService SoftwareService, IMapper mapper)
        {
            _SoftwareService = SoftwareService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SoftwareDto>> GetAll()
        {
            var listaSoftware = _SoftwareService.GetAll();
            var listaSoftwareDto = _mapper.Map<IEnumerable<SoftwareDto>>(listaSoftware);
            return Ok(listaSoftwareDto);
        }

        [HttpGet("{id}")]
        public ActionResult<SoftwareDto> GetById(int id)
        {
            var Software = _SoftwareService.GetById(id);
            if (Software == null)
            {
                return NotFound();
            }
            var SoftwareDto = _mapper.Map<SoftwareDto>(Software);
            return Ok(SoftwareDto);
        }

        [HttpPost]
        public ActionResult<SoftwareDto> Criar(SoftwareDto softwareDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var software = _mapper.Map<Software>(softwareDto);

            try
            {
                var softwareCriado = _SoftwareService.AdicionarSoftware(software);
                var softwareRetornoDto = _mapper.Map<SoftwareDto>(softwareCriado);
                return CreatedAtAction(nameof(GetById), new { id = softwareCriado.Id }, softwareRetornoDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar a placa-mãe: {ex.Message}");
            }
        }

    }
}
