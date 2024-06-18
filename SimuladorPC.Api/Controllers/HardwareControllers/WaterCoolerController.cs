using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/WaterCooler")]
    public class WaterCoolerController : ControllerBase
    {
        private readonly IWaterCoolerService _WaterCoolerService;
        private readonly IMapper _mapper;

        public WaterCoolerController(IWaterCoolerService WaterCoolerService, IMapper mapper)
        {
            _WaterCoolerService = WaterCoolerService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WaterCoolerDto>> GetAll()
        {
            var listaWaterCooler = _WaterCoolerService.GetAll();
            var listaWaterCoolerDto = _mapper.Map<IEnumerable<WaterCoolerDto>>(listaWaterCooler);
            return Ok(listaWaterCoolerDto);
        }

        [HttpGet("{id}")]
        public ActionResult<WaterCoolerDto> GetById(int id)
        {
            var WaterCooler = _WaterCoolerService.GetById(id);
            if (WaterCooler == null)
            {
                return NotFound();
            }
            var WaterCoolerDto = _mapper.Map<WaterCoolerDto>(WaterCooler);
            return Ok(WaterCoolerDto);
        }

        [HttpPost]
        public ActionResult<WaterCoolerDto>AdicionarWaterCooler(WaterCoolerDto WaterCoolerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            WaterCooler WaterCooler;
            try
            {
                WaterCooler = _mapper.Map<WaterCooler>(WaterCoolerDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            WaterCooler WaterCoolerCriado;
            try
            {
                WaterCoolerCriado = _WaterCoolerService.AdicionarWaterCooler(WaterCooler);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o objeto: {ex.Message}");
            }

            if (WaterCoolerCriado == null)
            {
                return BadRequest("Não foi possível criar o objeto.");
            }

            WaterCoolerDto WaterCoolerRetornoDto;
            try
            {
                WaterCoolerRetornoDto = _mapper.Map<WaterCoolerDto>(WaterCoolerCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(GetById), new { id = WaterCoolerCriado.Id }, WaterCoolerRetornoDto);
        }

    }
}
