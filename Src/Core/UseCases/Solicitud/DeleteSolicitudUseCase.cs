using Application.Common.DataAccess;

public class DeleteSolicitudUseCase
{
    ISolicitudRepository repository;

    public DeleteSolicitudUseCase(ISolicitudRepository repository)
    {
        this.repository = repository;
    }

    public void Execute(int Id)
    {
        this.repository.DeleteSolicitud(Id);
    }
}