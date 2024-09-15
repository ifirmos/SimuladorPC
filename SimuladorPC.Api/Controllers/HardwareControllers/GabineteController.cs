using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Services;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/gabinete")]
    public class GabineteController : ControllerBase
    {
        private readonly IGabineteService _gabineteService;
        private readonly IMapper _mapper;

        public GabineteController(IGabineteService gabineteService, IMapper mapper)
        {
            _gabineteService = gabineteService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GabineteDto>> GetAll()
        {
            var gabinetes = _gabineteService.GetAll();
            var gabinetesDto = _mapper.Map<IEnumerable<GabineteDto>>(gabinetes);
            return Ok(gabinetesDto);
        }

        [HttpGet("{id}")]
        public ActionResult<GabineteDto> ObterPorId(int id)
        {
            var gabinete = _gabineteService.ObterPorId(id);
            if (gabinete == null)
            {
                return NotFound();
            }
            var gabineteDto = _mapper.Map<GabineteDto>(gabinete);
            return Ok(gabineteDto);
        }

        [HttpPost]
        public ActionResult<GabineteDto> Criar(GabineteDto gabineteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            Gabinete gabinete;
            try
            {
                gabinete = _mapper.Map<Gabinete>(gabineteDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Gabinete gabineteCriado;
            try
            {
                gabineteCriado = _gabineteService.Add(gabinete);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o gabinete: {ex.Message}");
            }

            if (gabineteCriado == null)
            {
                return BadRequest("Não foi possível criar o gabinete.");
            }

            GabineteDto gabineteRetornoDto;
            try
            {
                gabineteRetornoDto = _mapper.Map<GabineteDto>(gabineteCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o gabinete criado para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(ObterPorId), new { id = gabineteCriado.Id }, gabineteRetornoDto);
        }

    }
}
