namespace Application.Common.DataAccess;

public interface IDbContext
{
    ISolicitudRepository SolicitudRepository { get; }

}