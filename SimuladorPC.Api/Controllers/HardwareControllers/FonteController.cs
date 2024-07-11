using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/Fonte")]
    public class FonteController : ControllerBase
    {
        private readonly IFonteService _fonteService;
        private readonly IMapper _mapper;

        public FonteController(IFonteService fonteService, IMapper mapper)
        {
            _fonteService = fonteService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FonteDto>> GetAll()
        {
            var fontes = _fonteService.GetAll();
            var fontesDto = _mapper.Map<IEnumerable<FonteDto>>(fontes);
            return Ok(fontesDto);
        }

        [HttpGet("{id}")]
        public ActionResult<FonteDto> ObterPorId(int id)
        {
            var fonte = _fonteService.ObterPorId(id);
            if (fonte == null)
            {
                return NotFound();
            }
            var fonteDto = _mapper.Map<FonteDto>(fonte);
            return Ok(fonteDto);
        }

        [HttpPost]
        public ActionResult<FonteDto> Criar(FonteDto fonteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Fonte fonte;
            try
            {
                fonte = _mapper.Map<Fonte>(fonteDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Fonte fonteCriado;
            try
            {
                fonteCriado = _fonteService.Add(fonte);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar a fonte: {ex.Message}");
            }

            if (fonteCriado == null)
            {
                return BadRequest("Não foi possível criar a fonte.");
            }

            FonteDto fonteRetornoDto;
            try
            {
                fonteRetornoDto = _mapper.Map<FonteDto>(fonteCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear a fonte criada para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(ObterPorId), new { id = fonteCriado.Id }, fonteRetornoDto);
        }

    }
}
