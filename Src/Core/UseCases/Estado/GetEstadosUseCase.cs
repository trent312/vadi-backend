using Application.Common.DataAccess;

public class GetEstadosUseCase
{
    IEstadoRepository repository;
    public GetEstadosUseCase(IEstadoRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Estado> Execute()
    {
        return this.repository.GetEstados();
    }
}