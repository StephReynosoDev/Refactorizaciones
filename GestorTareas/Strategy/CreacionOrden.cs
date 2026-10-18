using GestorTareas.Models;

namespace GestorTareas.Strategy;

public class CreacionOrden : IOrdenamiento
{
    public List<Tarea> Ordenar(List<Tarea> tareas)
    {
        return tareas.OrderByDescending(t => t.FechaCreacion).ToList();
    }
}