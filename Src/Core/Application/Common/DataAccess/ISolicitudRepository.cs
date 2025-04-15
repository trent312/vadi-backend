using Domain.Entidades;

namespace Application.Common.DataAccess;

public interface ISolicitudRepository
{
    IEnumerable<Solicitud> GetSolicitudes();
    void InsertSolicitud(Solicitud solicitud);
    void UpdateSolicitud(Solicitud solicitud);
    void DeleteSolicitud(int idSolicitud);
}