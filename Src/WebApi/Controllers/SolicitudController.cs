using Domain.Entidades;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SolicitudController : ControllerBase
{
    [HttpGet(Name = "Solicitud")]
    public IActionResult Get()
    {
        try 
        {
            GetSolicitudesUseCase useCase = new GetSolicitudesUseCase(new SolicitudRepository());
            var solicitudes = useCase.Execute().ToList();
            return Ok(solicitudes);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Route("Insert")]
    [HttpPost(Name = "Insert")]
    public IActionResult Insert([FromBody]Solicitud solicitud)
    {
        try
        {
            InsertSolicitudUseCase useCase = new InsertSolicitudUseCase(new SolicitudRepository());
            useCase.execute(solicitud);
            return Ok();
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
