using Domain.Entidades;

namespace Application.Common.DataAccess;

public interface IEstadoRepository
{
    IEnumerable<Estado> GetEstados();
}
