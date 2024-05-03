using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Software;

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
        public ActionResult<SoftwareDto> Criar(SoftwareDto SoftwareDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Software Software;
            try
            {
                Software = _mapper.Map<Software>(SoftwareDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Software SoftwareCriado;
            try
            {
                SoftwareCriado = _SoftwareService.Add(Software);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o objeto: {ex.Message}");
            }

            if (SoftwareCriado == null)
            {
                return BadRequest("Não foi possível criar o objeto.");
            }

            SoftwareDto SoftwareRetornoDto;
            try
            {
                SoftwareRetornoDto = _mapper.Map<SoftwareDto>(SoftwareCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(GetById), new { id = SoftwareCriado.Id }, SoftwareRetornoDto);
        }

    }
}
