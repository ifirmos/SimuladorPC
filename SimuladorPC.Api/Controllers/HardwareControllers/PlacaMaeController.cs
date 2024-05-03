using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/placaMae")]
    public class PlacaMaeController : ControllerBase
    {
        private readonly IPlacaMaeService _placaMaeService;
        private readonly IMapper _mapper;

        public PlacaMaeController(IPlacaMaeService placaMaeService, IMapper mapper)
        {
            _placaMaeService = placaMaeService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlacaMaeDto>> GetAll()
        {
            var placaMaes = _placaMaeService.GetAll();
            var placaMaesDto = _mapper.Map<IEnumerable<PlacaMaeDto>>(placaMaes);
            return Ok(placaMaesDto);
        }

        [HttpGet("{id}")]
        public ActionResult<PlacaMaeDto> GetById(int id)
        {
            var placaMae = _placaMaeService.GetById(id);
            if (placaMae == null)
            {
                return NotFound();
            }
            var placaMaeDto = _mapper.Map<PlacaMaeDto>(placaMae);
            return Ok(placaMaeDto);
        }

        [HttpPost]
        public ActionResult<PlacaMaeDto> Criar(PlacaMaeDto placaMaeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            PlacaMae placaMae;
            try
            {
                placaMae = _mapper.Map<PlacaMae>(placaMaeDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            PlacaMae placaMaeCriada;
            try
            {
                placaMaeCriada = _placaMaeService.Add(placaMae);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o placaMae: {ex.Message}");
            }

            if (placaMaeCriada == null)
            {
                return BadRequest("Não foi possível criar o placaMae.");
            }

            PlacaMaeDto placaMaeRetornoDto;
            try
            {
                placaMaeRetornoDto = _mapper.Map<PlacaMaeDto>(placaMaeCriada);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o placaMae criado para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(GetById), new { id = placaMaeCriada.Id }, placaMaeRetornoDto);
        }

    }
}
