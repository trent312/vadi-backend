using Application.Common.DataAccess;
using Domain.Entidades;

public class GetSolicitudesUseCase
{
    private ISolicitudRepository repository;

    public GetSolicitudesUseCase(ISolicitudRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Solicitud> Execute()
    {
        return this.repository.GetSolicitudes();
    }
}