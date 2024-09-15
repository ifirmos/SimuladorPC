using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Application.DTO;
using AutoMapper;
using SimuladorPC.Domain.Interfaces.Services;
using SimuladorPC.Domain.Entities.Hardware;
using System;

namespace SimuladorPC.Api.Controllers.HardwareControllers
{
    [ApiController]
    [Route("api/placamae")]
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
            var placaMaesDto = _mapper.Map<IEnumerable<PlacaMaeDto>>(placaMaes).ToList();
            return Ok(placaMaesDto);
        }

        //[HttpGet("cpusCompativeis/{placaMaeId}")] Refatorar
        //public ActionResult<IEnumerable<Cpu>> ListarCpusCompativeis(int placaMaeId)
        //{            
        //    var processadoresCompativeis = _placaMaeService.ListarCpusCompativeis(placaMaeId);
        //    var processadoresCompativeisDto = _mapper.Map<IEnumerable<CpuDto>>(processadoresCompativeis);
        //    return Ok(processadoresCompativeisDto);
        //}

        [HttpGet("{id}")]
        public ActionResult<PlacaMaeDto> ObterPorId(int id)
        {
            var placaMae = _placaMaeService.ObterPorId(id);
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

            var placaMae = _mapper.Map<PlacaMae>(placaMaeDto);

            try
            {
                var placaMaeCriada = _placaMaeService.AdicionarPlacaMae(placaMae);
                var placaMaeRetornoDto = _mapper.Map<PlacaMaeDto>(placaMaeCriada);
                return placaMaeRetornoDto;
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar a placa-mãe: {ex.Message}");
            }
        }
    }
}
