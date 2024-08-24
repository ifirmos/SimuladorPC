using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/gpu")]
    public class GpuController : ControllerBase
    {
        private readonly IGpuService _gpuService;
        private readonly IMapper _mapper;

        public GpuController(IGpuService gpuService, IMapper mapper)
        {
            _gpuService = gpuService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GpuDto>> GetAll()
        {
            var listaGpu = _gpuService.GetAll();
            var listaGpuDto = _mapper.Map<IEnumerable<GpuDto>>(listaGpu);
            return Ok(listaGpuDto);
        }

        [HttpGet("id")]
        public ActionResult<GpuDto> ObterPorId(int id)
        {
            var gpu = _gpuService.ObterPorId(id);
            if (gpu == null)
            {
                return NotFound();
            }
            var gpuDto = _mapper.Map<GpuDto>(gpu);
            return Ok(gpuDto);
        }

        [HttpGet("placasMaeCompativeis")]
        public ActionResult<IEnumerable<PlacaMaeDto>> ListarPlacasMaeCompativeis(int gpuId)
        {
            var listaPlacaMae = _gpuService.ListarPlacasMaeCompativeis(gpuId);
            var listaPlacaMaeDto = _mapper.Map<IEnumerable<PlacaMaeDto>>(listaPlacaMae);
            return Ok(listaPlacaMaeDto);
        }

        [HttpPost]
        public ActionResult<GpuDto> Criar(GpuDto gpuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna os erros de validação
            }

            Gpu gpu;
            try
            {
                gpu = _mapper.Map<Gpu>(gpuDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o objeto: {ex.Message}");
            }

            Gpu gpuCriado;
            try
            {
                gpuCriado = _gpuService.Add(gpu);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar o gpu: {ex.Message}");
            }

            if (gpuCriado == null)
            {
                return BadRequest("Não foi possível criar o gpu.");
            }

            GpuDto gpuRetornoDto;
            try
            {
                gpuRetornoDto = _mapper.Map<GpuDto>(gpuCriado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao mapear o gpu criado para DTO: {ex.Message}");
            }

            return CreatedAtAction(nameof(ObterPorId), new { id = gpuCriado.Id }, gpuRetornoDto);
        }

        [HttpPut("{id}/adicionar-imagens")]
        public ActionResult<GpuDto> AdicionarImagens(int id, [FromBody] IList<string> urlsImagens)
        {
            if (urlsImagens == null || !urlsImagens.Any())
            {
                return BadRequest("A lista de URLs de imagens não pode ser nula ou vazia.");
            }

            var gpu = _gpuService.ObterPorId(id);
            if (gpu == null)
            {
                return NotFound($"GPU com ID {id} não encontrada.");
            }

            try
            {
                foreach (var url in urlsImagens)
                {
                    gpu.AdicionarImagem(url);
                }

                _gpuService.Update(gpu);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar as imagens: {ex.Message}");
            }

            var gpuDto = _mapper.Map<GpuDto>(gpu);
            return Ok(gpuDto);
        }
    }
}
