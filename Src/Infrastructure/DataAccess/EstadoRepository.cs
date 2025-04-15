using Application.Common.DataAccess;
using Dapper;
using Domain.Entidades;
using Microsoft.Data.SqlClient;

namespace Infrastructure.DataAccess;

public class EstadoRepository : IEstadoRepository
{
    private const string CONNECTION_STRING = "server=db-test-01.cisujwojstyy.us-east-1.rds.amazonaws.com;initial catalog=Evaluacion02;user id=UserEval02;password=UserEval02**$;TrustServerCertificate=True";

    public IEnumerable<Estado> GetEstados()
    {
        string query = "exec usp_estado_get";

        SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        List<Estado> estados = connection.Query<Estado>(query).ToList();
        return estados;
    }
}
