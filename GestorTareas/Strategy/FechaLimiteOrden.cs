using GestorTareas.Models;

namespace GestorTareas.Strategy;

public class FechaLimiteOrden : IOrdenamiento
{
    public List<Tarea> Ordenar(List<Tarea> tareas)
    {
        return tareas.OrderBy(t => t.FechaLimite).ToList();
    }
}