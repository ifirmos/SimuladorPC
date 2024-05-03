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
        private readonly IRequisitosHardwareService _RequisitosHardwareService;
        private readonly IMapper _mapper;

        public RequisitosHardwareController(IRequisitosHardwareService RequisitosHardwareService, IMapper mapper)
        {
            _RequisitosHardwareService = RequisitosHardwareService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RequisitosHardwareDto>> GetAll()
        {
            var listaRequisitosHardware = _RequisitosHardwareService.GetAll();
            var listaRequisitosHardwareDto = _mapper.Map<IEnumerable<RequisitosHardwareDto>>(listaRequisitosHardware);
            return Ok(listaRequisitosHardwareDto);
        }

        [HttpGet("{id}")]
        public ActionResult<RequisitosHardwareDto> GetById(int id)
        {
            var RequisitosHardware = _RequisitosHardwareService.GetById(id);
            if (RequisitosHardware == null)
            {
                return NotFound();
            }
            var RequisitosHardwareDto = _mapper.Map<RequisitosHardwareDto>(RequisitosHardware);
            return Ok(RequisitosHardwareDto);
        }

        [HttpPost]
        public ActionResult<RequisitosHardwareDto> Criar(RequisitosHardwareDto RequisitosHardwareDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            RequisitosHardware RequisitosHardware;
            try
            {
                RequisitosHardware = _mapper.Map<RequisitosHardware>(RequisitosHardwareDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            RequisitosHardware RequisitosHardwareCriado;
            try
            {
                RequisitosHardwareCriado = _RequisitosHardwareService.Add(RequisitosHardware);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o objeto: {ex.Message}");
            }

            if (RequisitosHardwareCriado == null)
            {
                return BadRequest("Não foi possível criar o objeto.");
            }

            RequisitosHardwareDto RequisitosHardwareRetornoDto;
            try
            {
                RequisitosHardwareRetornoDto = _mapper.Map<RequisitosHardwareDto>(RequisitosHardwareCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(GetById), new { id = RequisitosHardwareCriado.Id }, RequisitosHardwareRetornoDto);
        }

    }
}
