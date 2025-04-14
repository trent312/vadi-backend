using Domain.Entidades;

namespace Application.Common.DataAccess;

public interface ISolicitudRepository
{
    IEnumerable<Solicitud> GetSolicitudes();

}