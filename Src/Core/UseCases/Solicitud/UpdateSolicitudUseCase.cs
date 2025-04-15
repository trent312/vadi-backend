using Application.Common.DataAccess;
using Domain.Entidades;

public class UpdateSolicitudUseCase
{
    ISolicitudRepository repository;

    public UpdateSolicitudUseCase(ISolicitudRepository repository)
    {
        this.repository = repository;
    }

    public void Execute(Solicitud solicitud)
    {
        this.repository.UpdateSolicitud(solicitud);
    }
}