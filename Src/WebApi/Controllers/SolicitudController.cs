using Domain.Entidades;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SolicitudController : ControllerBase
{
    [HttpGet(Name = "Solicitud")]
    public IEnumerable<Solicitud> Get()
    {
        GetSolicitudesUseCase useCase = new GetSolicitudesUseCase(new SolicitudRepository());
        return useCase.Execute();
    }
}
