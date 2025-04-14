using Application.Common.DataAccess;
using Domain.Entidades;

namespace Infrastructure.DataAccess;

public class SolicitudRepository : ISolicitudRepository
{
    private readonly string _connectionString;

    public SolicitudRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<Solicitud> GetSolicitudes()
    {
        throw new NotImplementedException();
    }
}
