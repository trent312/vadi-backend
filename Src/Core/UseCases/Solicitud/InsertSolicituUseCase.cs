using Application.Common.DataAccess;
using Domain.Entidades;

public class InsertSolicitudUseCase
{
    private ISolicitudRepository repository;
    
    public InsertSolicitudUseCase(ISolicitudRepository repository)
    {
        this.repository = repository;
    }

    public void execute(Solicitud solicitud)
    {
        this.repository.InsertSolicitud(solicitud);
    }
}

