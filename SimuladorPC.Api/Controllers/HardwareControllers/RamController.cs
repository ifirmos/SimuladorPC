using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/ram")]
    public class RamController : ControllerBase
    {
        private readonly IRamService _RamService;
        private readonly IMapper _mapper;

        public RamController(IRamService RamService, IMapper mapper)
        {
            _RamService = RamService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RamDto>> GetAll()
        {
            var listaRam = _RamService.GetAll();
            var listaRamDto = _mapper.Map<IEnumerable<RamDto>>(listaRam);
            return Ok(listaRamDto);
        }

        [HttpGet("{id}")]
        public ActionResult<RamDto> ObterPorId(int id)
        {
            var Ram = _RamService.ObterPorId(id);
            if (Ram == null)
            {
                return NotFound();
            }
            var RamDto = _mapper.Map<RamDto>(Ram);
            return Ok(RamDto);
        }

        [HttpPost]
        public ActionResult<RamDto>AdicionarRam(RamDto RamDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ram Ram;
            try
            {
                Ram = _mapper.Map<Ram>(RamDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Ram RamCriada;
            try
            {
                RamCriada = _RamService.Add(Ram);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o objeto: {ex.Message}");
            }

            if (RamCriada == null)
            {
                return BadRequest("Não foi possível criar o objeto.");
            }

            RamDto RamRetornoDto;
            try
            {
                RamRetornoDto = _mapper.Map<RamDto>(RamCriada);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(ObterPorId), new { id = RamCriada.Id }, RamRetornoDto);
        }

    }
}
