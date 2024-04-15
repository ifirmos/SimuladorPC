using Microsoft.AspNetCore.Mvc;
using SimuladorPC.Domain.Entities;
using SimuladorPC.Domain.Interfaces.Services;

namespace SimuladorPC.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GabineteController : ControllerBase
    {
    private readonly IGabineteService _gabineteService;

    public GabineteController(IGabineteService gabineteService)
    {
        _gabineteService = gabineteService;
    }

    [HttpPost]
    public IActionResult AddGabinete(Gabinete gabinete)
    {
        _gabineteService.AdicionarGabinete(gabinete);
        return Ok();
    }

    [HttpGet]
    public IActionResult ListarGabinetes()
    {
        var gabinetes = _gabineteService.GetAllGabinetes();
        return Ok(gabinetes);
    }

    [HttpGet]
    public IActionResult ObterGabinetePorId(int id)
    {
        var gabinetes = _gabineteService.ObterGabinetePorId(id);
        return Ok(gabinetes);
    }
}
    
