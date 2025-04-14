namespace Domain.Entidades;

public class Solicitud
{
    public int Id { get; set; }
    public string FechaSolicitud { get; set; } = string.Empty;
    public string Solicitante { get; set; } = string.Empty;
    public int IdEstado { get; set; }
}
