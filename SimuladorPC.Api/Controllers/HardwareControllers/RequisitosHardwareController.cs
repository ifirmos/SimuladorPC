using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Software;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/RequisitosHardware")]
    public class RequisitosHardwareController : ControllerBase
    {
        private readonly IRequisitosHardwareService _requisitosHardwareService;
        private readonly ISoftwareService _softwareService;
        private readonly IMapper _mapper;

        public RequisitosHardwareController(IRequisitosHardwareService requisitosHardwareService, ISoftwareService softwareService, IMapper mapper)
        {
            _requisitosHardwareService = requisitosHardwareService;
            _softwareService = softwareService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RequisitosHardwareDto>> GetAll()
        {
            var listaRequisitosHardware = _requisitosHardwareService.GetAll();
            var listaRequisitosHardwareDto = _mapper.Map<IEnumerable<RequisitosHardwareDto>>(listaRequisitosHardware);
            return Ok(listaRequisitosHardwareDto);
        }

        [HttpGet("{id}")]
        public ActionResult<RequisitosHardwareDto> GetById(int id)
        {
            var requisitosHardware = _requisitosHardwareService.GetById(id);
            if (requisitosHardware == null)
            {
                return NotFound();
            }
            var requisitosHardwareDto = _mapper.Map<RequisitosHardwareDto>(requisitosHardware);
            return Ok(requisitosHardwareDto);
        }

        [HttpPost]
        public ActionResult<RequisitosHardwareDto> Criar(RequisitosHardwareDto requisitosHardwareDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var software = _softwareService.GetById(requisitosHardwareDto.SoftwareId);
            if (software == null)
            {
                return NotFound("Software não encontrado.");
            }

            var requisitosHardware = _mapper.Map<RequisitosHardware>(requisitosHardwareDto);
            var requisitosHardwareCriado = _requisitosHardwareService.Add(requisitosHardware);
            var requisitosHardwareRetornoDto = _mapper.Map<RequisitosHardwareDto>(requisitosHardwareCriado);

            return CreatedAtAction(nameof(GetById), new { id = requisitosHardwareCriado.Id }, requisitosHardwareRetornoDto);
        }
    }
}
