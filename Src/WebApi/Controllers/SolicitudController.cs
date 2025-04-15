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
    [HttpPost]
    public IActionResult Insert([FromBody]Solicitud solicitud)
    {
        try
        {
            InsertSolicitudUseCase useCase = new InsertSolicitudUseCase(new SolicitudRepository());
            useCase.Execute(solicitud);
            return Ok();
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Route("Update")]
    [HttpPost]
    public IActionResult Update([FromBody]Solicitud solicitud)
    {
        try
        {
            UpdateSolicitudUseCase useCase = new UpdateSolicitudUseCase(new SolicitudRepository());
            useCase.Execute(solicitud);
            return Ok();
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
