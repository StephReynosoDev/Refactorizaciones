using GestorTareas.Models;

namespace GestorTareas.Strategy;

public class UrgenciaOrden : IOrdenamiento
{
    public List<Tarea> Ordenar(List<Tarea> tareas)
    {
        var hoy = DateTime.Now;
        return tareas
            .OrderBy(t => t.Estado == EstadoTarea.Completada ? 2 : t.FechaLimite < hoy ? 0 : 1)
            .ThenBy(t => t.Estado == EstadoTarea.Pendiente && t.FechaLimite >= hoy ? t.FechaLimite : DateTime.MaxValue)
            .ThenBy(t => t.FechaCreacion)
            .ToList();
    }
}