using Application.Common.DataAccess;
using Dapper;
using Domain.Entidades;
using Microsoft.Data.SqlClient;

namespace Infrastructure.DataAccess;

public class SolicitudRepository : ISolicitudRepository
{
    private const string CONNECTION_STRING = "server=db-test-01.cisujwojstyy.us-east-1.rds.amazonaws.com;initial catalog=Evaluacion02;user id=UserEval02;password=UserEval02**$;TrustServerCertificate=True";

    public void DeleteSolicitud(int idSolicitud)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Solicitud> GetSolicitudes()
    {
        string query = "exec usp_solicitud_get";

        SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        List<Solicitud> solicitudes = connection.Query<Solicitud>(query).ToList();
        return solicitudes;
    }

    public void InsertSolicitud(Solicitud solicitud)
    {
        string query = "exec usp_solicitud_insert @FechaSolicitud, @Solicitante, @IdEstado";

        SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        connection.Query(query, solicitud);
    }

    public void UpdateSolicitud(Solicitud solicitud)
    {
        string query = "exec usp_solicitud_update @Id, @FechaSolicitud, @Solicitante, @IdEstado";

        SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        connection.Query(query, solicitud);
    }
}
