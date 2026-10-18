namespace GestorTareas.Models;

public enum EstadoTarea
{
    Pendiente,
    Completada
}

public class Tarea
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaLimite { get; set; }
    public EstadoTarea Estado { get; set; }
}