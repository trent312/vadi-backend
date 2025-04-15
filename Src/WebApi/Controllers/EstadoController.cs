using Domain.Entidades;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EstadoController : ControllerBase
{
    [HttpGet(Name = "Estado")]
    public IActionResult Get()
    {
        try 
        {
            GetEstadosUseCase useCase = new GetEstadosUseCase(new EstadoRepository());
            var estados = useCase.Execute().ToList();
            return Ok(estados);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
