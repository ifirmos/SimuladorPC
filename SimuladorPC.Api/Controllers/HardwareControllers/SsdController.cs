using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;
using SimuladorPC.Application.DTO;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/ssd")]
    public class SsdController : ControllerBase
    {
        private readonly ISsdService _SsdService;
        private readonly IMapper _mapper;

        public SsdController(ISsdService SsdService, IMapper mapper)
        {
            _SsdService = SsdService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SsdDto>> GetAll()
        {
            var listaSsd = _SsdService.GetAll();
            var listaSsdDto = _mapper.Map<IEnumerable<SsdDto>>(listaSsd);
            return Ok(listaSsdDto);
        }

        [HttpGet("{id}")]
        public ActionResult<SsdDto> ObterPorId(int id)
        {
            var Ssd = _SsdService.ObterPorId(id);
            if (Ssd == null)
            {
                return NotFound();
            }
            var SsdDto = _mapper.Map<SsdDto>(Ssd);
            return Ok(SsdDto);
        }

        [HttpPost]
        public ActionResult<SsdDto> Criar(SsdDto SsdDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ssd Ssd;
            try
            {
                Ssd = _mapper.Map<Ssd>(SsdDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Ssd SsdCriado;
            try
            {
                SsdCriado = _SsdService.Add(Ssd);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o objeto: {ex.Message}");
            }

            if (SsdCriado == null)
            {
                return BadRequest("Não foi possível criar o objeto.");
            }

            SsdDto SsdRetornoDto;
            try
            {
                SsdRetornoDto = _mapper.Map<SsdDto>(SsdCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(ObterPorId), new { id = SsdCriado.Id }, SsdRetornoDto);
        }

    }
}
